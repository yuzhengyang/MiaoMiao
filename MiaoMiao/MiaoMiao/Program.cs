using MiaoMiao.Commons;
using MiaoMiao.Modules.ClockModule;
using MiaoMiao.Modules.PictureModule;
using MiaoMiao.Views.MainViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiaoMiao
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            R.MainUI = new MainForm();

            Clock.Start();

            Application.Run(R.MainUI);
        }
    }
}
