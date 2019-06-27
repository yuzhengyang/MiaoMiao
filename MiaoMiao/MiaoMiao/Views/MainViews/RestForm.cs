using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.DataUtils.DateTimeUtils;
using Azylee.Core.DataUtils.StringUtils;
using MiaoMiao.Commons;
using MiaoMiao.Models;
using MiaoMiao.Modules.PictureModule;
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
        public ImageModel CurrentImage = null;
        public int ShowTime_Max = 5 * 20;
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

            LbCopyright.Left = 20;
            LbCopyright.Top = Height - LbCopyright.Height - 20;
            LbTime.Left = Width - LbTime.Width - 20;
            LbTime.Top = 40;
            LbDate.Left = Width - LbDate.Width - 30;
            LbDate.Top = LbTime.Height + 60;
            LbChineseHour.Left = LbTime.Left - LbChineseHour.Width - 20;
            LbChineseHour.Top = LbTime.Top + LbTime.Height - LbChineseHour.Height - 10;
        }

        private void LbLike_Click(object sender, EventArgs e)
        {
            if (CurrentImage != null)
            {
                CurrentImage.Like = !CurrentImage.Like;
                LbLike.Text = CurrentImage.Like ? "♥" : "♡";
                PictureHelper.SetLike(CurrentImage.Copyright, CurrentImage.Like);
            }
            else
            {
                LbLike.Text = "";
            }
        }
        private void RestForm_DoubleClick(object sender, EventArgs e)
        {
            if (ShowTime_Current >= ShowTime_Max) CancelRest();
        }
        public void Rest(ImageModel model)
        {
            try
            {
                CurrentImage = model;
                R.MainUI.Invoke(new Action(() =>
                {
                    UIDateTime();
                    ShowTime_Current = 0;
                    LbProgress.Width = 0;
                    TmMain.Enabled = true;
                    TmTime.Enabled = true;
                    //设置背景图
                    if (model != null && Str.Ok(model.File))
                    {
                        LbLike.Text = model.Like ? "♥" : "♡";
                        LbCopyright.Text = model.Copyright;
                        BackgroundImage = Image.FromFile(model.File);
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
                    TmTime.Enabled = false;
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
                TmMain.Enabled = false;
            }
            else
            {
                float width = ((float)ShowTime_Current / ShowTime_Max) * PnProgress.Width;
                LbProgress.Width = (int)width;
            }
        }
        private void TmTime_Tick(object sender, EventArgs e)
        {
            UIDateTime();
        }

        #region UI操作
        private void UIDateTime()
        {
            DateTime now = DateTime.Now;
            LbTime.Text = now.ToString("HH:mm");
            LbDate.Text = $"{now.Month}月{now.Day}日 {WeekDayTool.ToWeekDay(now)}";
            LbChineseHour.Text = ChineseHourTool.GetDesc(now);
        }
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
