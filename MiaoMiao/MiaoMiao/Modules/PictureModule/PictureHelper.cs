using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.IOUtils.DirUtils;
using Azylee.Core.IOUtils.FileUtils;
using Azylee.Core.ThreadUtils.SleepUtils;
using Azylee.Jsons;
using Azylee.YeahWeb.ExtWebAPI.BingWebAPI.WallpaperUtils;
using Azylee.YeahWeb.HttpUtils;
using MiaoMiao.Commons;
using MiaoMiao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaoMiao.Modules.PictureModule
{
    public static class PictureHelper
    {
        /// <summary>
        /// 加载图片
        /// </summary>
        public static void ImageLoading()
        {
            //创建文件夹
            DirTool.Create(R.Paths.Pictures);

            //加载缓存
            var cache_list = Json.File2Object<List<ImageModel>>(R.Files.PicturesList);
            if (Ls.Ok(cache_list)) R.Images = cache_list;

            //读取最新图片
            WallpaperModel model = WallpaperTool.GetToday();
            if (model != null && Ls.Ok(model.images))
            {
                foreach (var item in model.images)
                {
                    string name = item.title;
                    string url = item.GetImageUrl();
                    string file = DirTool.Combine(R.Paths.Pictures, item.hsh + ".jpg");
                    //不存在的图片添加到缓存
                    if (!R.Images.Any(x => x.File == file))
                    {
                        if (HttpTool.Download(url, file))
                        {
                            R.Images.Add(new ImageModel()
                            {
                                Name = name,
                                Url = url,
                                File = file,
                                CreateTime = DateTime.Now,
                                LastDisplayTime = DateTime.MinValue,
                                DisplayCount = 0
                            });
                        }
                    }
                }

                //重新缓存图片信息
                Json.Object2File(R.Files.PicturesList, R.Images);
            }
        }
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <returns></returns>
        public static string GetImageFile()
        {
            var item = R.Images.OrderBy(x => x.LastDisplayTime).FirstOrDefault();
            if (item != null)
            {
                item.DisplayCount++;
                item.LastDisplayTime = DateTime.Now;

                //重新缓存图片信息
                Json.Object2File(R.Files.PicturesList, R.Images);
                return item.File;
            }
            return null;
        }
        public static void CleanImage()
        {
            if (Ls.Ok(R.Images))
            {
                //仅保留最近15天的图片记录（清理过期图片）
                DateTime expire_time = DateTime.Now.AddDays(-15);
                List<ImageModel> save_image = new List<ImageModel>();
                foreach (var item in R.Images)
                {
                    if (item.CreateTime > expire_time)
                    {
                        save_image.Add(item);
                    }
                    else
                    {
                        FileTool.Delete(item.File);
                    }
                }
                R.Images = save_image;
                //重新缓存图片信息
                Json.Object2File(R.Files.PicturesList, R.Images);
            }
        }
    }
}
