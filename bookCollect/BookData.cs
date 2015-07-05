using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pyystone;

namespace bookCollect
{
    public class BookData
    {
        public String bookName;
        public String lastPage;
        public int pageCount;
        public String bookType;
        public String bookUrl;
    }

    public class NetData
    {
        public String netUrl;
        public String netBookNameRex;
        public String netLastPageRex;
        public String netPageCountRex;
        public String netBookTypeRex;
        public String netBookUrlRex;
        public int loadPageCount;
        public int needLoadPagePosition = 1;

        public static List<NetData> getDatasByCsvFile(String fileName)
        {
            var reader = FileLS.fileReader(fileName);
            var datas = new List<NetData>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                var data = new NetData();;
                data.netUrl = @values[0];
                data.netBookNameRex = @values[1];
                data.netLastPageRex = @values[2];
                data.netBookTypeRex = @values[3];
                data.netBookUrlRex = @values[4];
                data.loadPageCount = Convert.ToInt32(values[5]);
                datas.Add(data);
            }
            return datas;
        }
    }
}
