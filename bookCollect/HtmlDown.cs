using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace pyystone
{
    class HtmlDown
    {
        static private WebClient init()//对 webclient进行初始化
        {
            WebClient MyWeb = new WebClient();
            MyWeb.Credentials = CredentialCache.DefaultCredentials;
            return MyWeb;
        }
        /// <summary>
        /// 获得网页源码，非动态
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        static public string DownHtmlPage(string url)
        {
            string strWebData = string.Empty;
            if (url != null || url.Trim() != "")
            {
                WebClient myWebClient = new WebClient();
                myWebClient.Credentials = CredentialCache.DefaultCredentials;
                byte[] myDataBuffer = myWebClient.DownloadData(url);
                strWebData = Encoding_deal(myDataBuffer);
            }
            return strWebData;
        }
        /// <summary>
        /// 下载指定数据资源
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileurl"></param>
        /// <returns></returns>
        static public bool DownHtmlFile(string url,string fileurl)
        {
            WebClient MyWeb = init();
            MyWeb.DownloadFile(url, fileurl);
            return true;
        }
        /// <summary>
        /// 编码处理
        /// </summary>
        /// <param name="strWebData"></param>
        /// <returns></returns>
        static public string Encoding_deal(byte[] myDataBuffer)
        {
            string strWebData = Encoding.Default.GetString(myDataBuffer);
            string charSet = "";
            Match charSetMatch = Regex.Match(strWebData, "<meta([^<]*)charset=([^<]*)\"", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string webCharSet = charSetMatch.Groups[2].Value;
            if (charSet == null || charSet == "")
            {
                //如果未获取到编码，则设置默认编码
                if (webCharSet == null || webCharSet == "")
                {
                    charSet = "UTF-8";
                }
                else
                {
                    charSet = webCharSet;
                }
            }
            if (charSet[0] == '\"')
            {
                charSet = charSet.Substring(1, charSet.Length - 1);
            }
            if (charSet != null && charSet != "" && Encoding.GetEncoding(charSet) != Encoding.Default)
            {
                strWebData = Encoding.GetEncoding(charSet).GetString(myDataBuffer);
            }
            return strWebData;
        }
    }
}
