using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.DataUtils.StringUtils;
using MiaoMiao.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiaoMiao.Views.MainViews
{
    public partial class RestForm : Form
    {
        public int ShowTime_Max = 2 * 60 * 10;
        public int ShowTime_Current = 0;
        public RestForm()
        {
            InitializeComponent();
        }

        private void RestForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;//设置无边框
            StartPosition = FormStartPosition.CenterScreen;//设置位置居中
            WindowState = FormWindowState.Maximized;//最大化显示
        }
        private void RestForm_DoubleClick(object sender, EventArgs e)
        {
            CancelRest();
        }
        public void Rest(string file)
        {
            try
            {
                R.MainUI.Invoke(new Action(() =>
                {
                    ShowTime_Current = 0;
                    LbProgress.Width = 0;
                    TmMain.Enabled = true;
                    //设置背景图
                    if (Str.Ok(file))
                    {
                        BackgroundImage = Image.FromFile(file);
                    }
                    ShowForm();
                }));
            }
            catch { }
        }
        public void CancelRest()
        {
            try
            {
                R.MainUI.Invoke(new Action(() =>
                {
                    ShowTime_Current = ShowTime_Max;
                    LbProgress.Width = 0;
                    TmMain.Enabled = false;
                    HideForm();
                }));
            }
            catch { }
        }

        private void TmMain_Tick(object sender, EventArgs e)
        {
            ShowTime_Current++;
            if (ShowTime_Current > ShowTime_Max)
            {
                //CancelRest();
            }
            else
            {
                float width = ((float)ShowTime_Current / ShowTime_Max) * PnProgress.Width;
                LbProgress.Width = (int)width;
            }
        }

        #region UI操作
        /// <summary>
        /// 隐藏窗口
        /// </summary>
        public void HideForm()
        {
            Opacity = 0;
            ShowInTaskbar = false;
            Hide();
        }
        /// <summary>
        /// 显示窗口
        /// </summary>
        public void ShowForm()
        {
            Opacity = 100;
            ShowInTaskbar = true;
            if (WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }
        #endregion

    }
}
