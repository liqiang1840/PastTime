using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SQLServerDAL
{
    /// <summary>
    /// 字符串处理类
    /// </summary>
    public class FomatString
    {
        #region 字符串截取函数
        /// <summary>
        /// 截取字符串方法
        /// </summary>
        /// <param name="inputString">要截取的原字符串</param>
        /// <param name="len">要截取的长度</param>
        /// <returns>截取后的字符串</returns>
        public string CutString(string inputString, int len)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = ascii.GetBytes(inputString);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen += 1;
                }

                try
                {
                    tempString += inputString.Substring(i, 1);
                }
                catch
                {
                    break;
                }

                if (tempLen > len)
                    break;
            }
            //如果截过则加上半个省略号
            byte[] mybyte = System.Text.Encoding.Default.GetBytes(inputString);
            if (mybyte.Length > len)
                tempString += "…";


            return tempString;
        }
        #endregion
    }
}