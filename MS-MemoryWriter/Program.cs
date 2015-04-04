using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MS_MemoryWriter
{
    static class Program
    {
        public static string tak = "taskmgr.exe";

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new frmAgreement().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
