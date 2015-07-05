using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using pyystone;

namespace bookCollect
{
    class BookDownLoadTask
    {
        private NetData data;
        private String url;
        private Thread t;
        private readonly BookCollectController.DataDownCallBack back;
        public BookDownLoadTask(NetData netData, String neturl,BookCollectController.DataDownCallBack callBack)
        {
            url = neturl;
            data = netData;
            back = callBack;
        }

        public void startTask()
        {
            t = new Thread(threadTask);
            t.IsBackground = true;
            t.Start();
        }

        public void destory()
        {
            if (t == null)
            {
                return;
            }
            t.Abort();
        }

        public int getPageCount(String pageCount)
        {
            String page = stringHelper.getStringByRex(pageCount, "第?(.*)[章回]");
            if (String.IsNullOrEmpty(page))
            {
                return -1;
            }
            if (page[0] >= '0' && page[0] <= '9')
            {
                try
                {
                    return Convert.ToInt32(page);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            int count = 0;
            foreach (var c in page)
            {
                switch (c)
                {
                    case '一':
                        count += 1;
                        break;
                    case '二':
                        count += 2;
                        break;
                    case '三':
                        count += 3;
                        break;
                    case '四':
                        count += 4;
                        break;
                    case '五':
                        count += 5;
                        break;
                    case '六':
                        count += 6;
                        break;
                    case '七':
                        count += 7;
                        break;
                    case '八':
                        count += 8;
                        break;
                    case '九':
                        count += 9;
                        break;
                    case '十':
                        if (count == 0)
                        {
                            count = 1;
                        }
                        count *= 10;
                        break;
                    case '百':
                        count *= 100;
                        break;
                    case '千':
                        count *= 1000;
                        break;
                }
            }
            return count;
        }

        public void threadTask()
        {
            try
            {
                var datas = new List<BookData>();
                String htmlData = HtmlDown.DownHtmlPage(url);
                var bookName = stringHelper.getrexDataByRex(htmlData,data.netBookNameRex).data;
                var lastPage = stringHelper.getrexDataByRex(htmlData, data.netLastPageRex).data;
                var bookType = stringHelper.getrexDataByRex(htmlData, data.netBookTypeRex).data;
                var bookUrl = stringHelper.getrexDataByRex(htmlData, data.netBookUrlRex).data;
                var nameListLength = bookName.Count;
                for (var i = 0; i < nameListLength; i++)
                {
                    BookData book = new BookData();
                    book.bookName = bookName[i];
                    if (lastPage != null && lastPage.Count > i)
                    {
                        book.lastPage = lastPage[i];
                        book.pageCount = getPageCount(lastPage[i]);
                    }
                    if (bookType != null && bookType.Count > i)
                    {
                        book.bookType = bookType[i];
                    }
                    if (bookUrl != null && bookUrl.Count > i)
                    {
                        book.bookUrl = bookUrl[i];
                    }
                    datas.Add(book);
                }
                back(datas);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.ToString());
            }
        }
    }
}
