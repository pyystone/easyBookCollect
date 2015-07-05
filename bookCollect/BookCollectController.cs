using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookCollect
{
    class BookCollectController
    {
        private static int threadCount = 10;
        private int minCount;
        private int maxCount;
        private Form1.FromDataCallBack callBack;
        private String urlFilePath;
        
        private int nowLoadNetPosition;
        private int needLoadCount;
        private int hasLoadCount;

        private List<NetData> netDatas = new List<NetData>(); 
        public delegate void DataDownCallBack(List<BookData> datas);

        public BookCollectController(int min, int max,String netUrlFile,Form1.FromDataCallBack Back)
        {
            minCount = min;
            maxCount = max;
            callBack = Back;
            urlFilePath = netUrlFile;
            initData();
        }

        private void initData()
        {
            nowLoadNetPosition = 0;
            getNetData();
            run();
        }

        private void getNetData()
        {
            netDatas = NetData.getDatasByCsvFile(urlFilePath);
            hasLoadCount = 0;
            needLoadCount = 0;
            foreach (var netData in netDatas)
            {
                needLoadCount += netData.loadPageCount;
            }

        }

        public void run()
        {
            for (var i = 1; i <= threadCount; i ++)
            {
                if (nowLoadNetPosition == netDatas.Count)
                {
                    break;
                }
                var data = netDatas[nowLoadNetPosition];
                new BookDownLoadTask(data, String.Format(data.netUrl, data.needLoadPagePosition), downCallBack).startTask();
                if (data.needLoadPagePosition == data.loadPageCount)
                {
                    nowLoadNetPosition ++;
                }
                else
                {
                    data.needLoadPagePosition ++;
                }
            }

        }

        public void downCallBack(List<BookData> datas)
        {
            var bookDatas = new List<BookData>();
            if (datas.Count != 0)
            {
                bookDatas = datas.Where(bookData => bookData.pageCount >= minCount && bookData.pageCount <= maxCount || bookData.pageCount == -1).ToList();
            }
            var obj = new object();
            lock (obj)
            {
                hasLoadCount ++;
                callBack(bookDatas,
                    hasLoadCount == needLoadCount
                        ? String.Format("下载完毕")
                        : String.Format("已下载 {0}/{1}", hasLoadCount, needLoadCount));
            }
            if (nowLoadNetPosition == netDatas.Count)
            {
                return;
            }
            var data = netDatas[nowLoadNetPosition];
            new BookDownLoadTask(data, String.Format(data.netUrl, data.needLoadPagePosition), downCallBack).startTask();
            if (data.needLoadPagePosition == data.loadPageCount)
            {
                nowLoadNetPosition++;
            }
            else
            {
                data.needLoadPagePosition++;
            }
        }

    }
}
