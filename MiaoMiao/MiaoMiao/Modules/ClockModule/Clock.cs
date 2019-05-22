using Azylee.Core.ThreadUtils.SleepUtils;
using MiaoMiao.Commons;
using MiaoMiao.Models;
using MiaoMiao.Modules.PictureModule;
using MiaoMiao.Views.MainViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaoMiao.Modules.ClockModule
{
    public static class Clock
    {
        public static List<DateTime> TimeList = new List<DateTime>();
        public static void Start()
        {
            Task.Factory.StartNew(() =>
            {
                //首次加载图片
                PictureHelper.ImageLoading();

                while (!R.MainUI.IsDisposed)
                {
                    if (DateTime.Now.Minute == 0 && DateTime.Now.Second < 5)
                    {
                        ImageModel file = PictureHelper.GetImage();
                        R.FormMan.GetUnique<RestForm>().Rest(file);

                        PictureHelper.ImageLoading();//每隔一小时下载图片
                        PictureHelper.CleanImage();//每隔一小时清理图片
                        Sleep.S(10);
                    }

                    Sleep.S(1);
                }
            });
        }
    }
}
