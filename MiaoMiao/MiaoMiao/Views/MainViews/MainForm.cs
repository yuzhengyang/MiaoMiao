using Azylee.Core.ThreadUtils.SleepUtils;
using MiaoMiao.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaoMiao.Views.MainViews
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HideForm();
        }

        #region UI操作
        /// <summary>
        /// 隐藏窗口
        /// </summary>
        private void HideForm()
        {
            Opacity = 0;
            ShowInTaskbar = false;
            Hide();
        }
        /// <summary>
        /// 显示窗口
        /// </summary>
        private void ShowForm()
        {
            Opacity = 100;
            ShowInTaskbar = true;
            if (WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }
        public void ExitApp()
        {
            //隐藏窗口图标
            try
            {
                Invoke(new Action(() => { NiMain.Visible = false; }));
            }
            catch { }

            //退出及强制退出
            Task.Factory.StartNew(() =>
            {
                Sleep.S(1);
                //正常退出
                try { Invoke(new Action(() => { Application.Exit(); })); } catch { }

                //延迟结束进程
                Azylee.Core.ProcessUtils.ProcessTool.SleepKill(Process.GetCurrentProcess(), 3);

                //强制退出
                Sleep.S(2);
                try { Environment.Exit(Environment.ExitCode); } catch { }
            });
        }
        #endregion
    }
}
