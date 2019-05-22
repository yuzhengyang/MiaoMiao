using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiaoMiao.Models
{
    public class ImageModel
    {
        public string Copyright { get; set; }
        public string Url { get; set; }
        public string File { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastDisplayTime { get; set; }
        public long DisplayCount { get; set; }
    }
}
