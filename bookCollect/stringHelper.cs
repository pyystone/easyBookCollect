using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pyystone
{
    class stringHelper
    {
        internal class rexData
        {
            public List<string> data;
            public rexData()
            {
                data = new List<string>();
            }
            ~rexData()
            {
                data = null;
            }
        }

        /// <summary>
        /// 将字符串分割成数组
        /// </summary>
        /// <param name="strSource"></param>
        /// <param name="strSplit"></param>
        /// <returns></returns>
        public static string[] StringSplit(string strSource, string strSplit)
        {
            string[] strtmp = new string[1];
            int index = strSource.IndexOf(strSplit, 0);
            if (index < 0)
            {
                strtmp[0] = strSource;
                return strtmp;
            }
            else
            {
                strtmp[0] = strSource.Substring(0, index);
                return StringSplit(strSource.Substring(index + strSplit.Length), strSplit, strtmp);
            }
        }

        /// <summary>
        /// 采用递归将字符串分割成数组
        /// </summary>
        /// <param name="strSource"></param>
        /// <param name="strSplit"></param>
        /// <param name="attachArray"></param>
        /// <returns></returns>
        private static string[] StringSplit(string strSource, string strSplit, string[] attachArray)
        {
            string[] strtmp = new string[attachArray.Length + 1];
            attachArray.CopyTo(strtmp, 0);

            int index = strSource.IndexOf(strSplit, 0);
            if (index < 0)
            {
                strtmp[attachArray.Length] = strSource;
                return strtmp;
            }
            else
            {
                strtmp[attachArray.Length] = strSource.Substring(0, index);
                return StringSplit(strSource.Substring(index + strSplit.Length), strSplit, strtmp);
            }
        }

        public static List<rexData> getStringByRex(string txt, string rex, int[] index)
        {
            List<rexData> res = new List<rexData>();
            rexData result = new rexData();
            Match charSetMatch = Regex.Match(txt, rex, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            while (charSetMatch.Success)
            {
                foreach (int i in index)
                {
                    result.data.Add(charSetMatch.Groups[i].Value);
                }
                res.Add(result);
                charSetMatch = charSetMatch.NextMatch();
            }
            return res;
        }

        public static rexData getrexDataByRex(string txt, string rex)
        {
            return getrexDataByRex(txt, rex, 1);
        }

        public static rexData getrexDataByRex(string txt, string rex, int index)
        {
            if (String.IsNullOrEmpty(txt) || String.IsNullOrEmpty(rex))
            {
                return null;
            }
            rexData result = new rexData();
            Match charSetMatch = Regex.Match(txt, rex, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            while (charSetMatch.Success)
            {
                result.data.Add(charSetMatch.Groups[index].Value);
                charSetMatch = charSetMatch.NextMatch();
            }
            return result;
        }
        public static string getStringByRex(string txt, string rex)
        {
            return getStringByRex(txt, rex, 1);
        }
        public static string getStringByRex(string txt, string rex, int index)
        {
            List<rexData> res = new List<rexData>();
            rexData result = new rexData();
            Match charSetMatch = Regex.Match(txt, rex, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            while (charSetMatch.Success)
            {
                return charSetMatch.Groups[index].Value;
            }
            return "";
        }

    }
}
