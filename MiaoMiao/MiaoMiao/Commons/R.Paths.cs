﻿using Azylee.Core.IOUtils.DirUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiaoMiao.Commons
{
    public static partial class R
    {
        public static class Paths
        {
            public static string App = AppDomain.CurrentDomain.BaseDirectory;
            public static string Pictures = DirTool.Combine(App, "Pictures");
        }
    }
}
