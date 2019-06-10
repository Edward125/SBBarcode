using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Edward;
using System.IO;

namespace SBBarcode
{
    class p
    {

        public enum RunTypeFlag
        {
            Manual,
            Auto
        }


        public static  RunTypeFlag RunType;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="msg"></param>
        public static void WriteLog(string filename, string msg)
        {
            StreamWriter sw = new StreamWriter(filename, false);
            sw.WriteLine(msg);
            sw.Close();

        }

        public static void WriteLog(string msg)
        {
            StreamWriter sw = new StreamWriter("Log.txt", true);
            string it = DateTime.Now.ToString("yyyyMMddHHmmss") + "->" + msg;
            sw.WriteLine(it);
            sw.Close();
        }

    }
}
