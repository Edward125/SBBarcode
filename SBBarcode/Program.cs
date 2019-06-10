using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SBBarcode
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                if (args[0].ToLower() == "auto")
                {
                    p.RunType = p.RunTypeFlag.Auto;
                    p.WriteLog("Auto Run");
                }


            }
            else
            {
                p.RunType = p.RunTypeFlag.Manual;
                p.WriteLog("Manual Run.");
                
            }
            Application.Run(new frmMain());
        }
    }
}
