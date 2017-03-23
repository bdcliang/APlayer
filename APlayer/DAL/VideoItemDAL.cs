using APlayer.Model;
using APlayer.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace APlayer.DAL
{
    class VideoItemDAL
    {
       public static  VideoItems GetVideoSources(string path)
        {
            var pattern = ".avi|.mp4|.mov|.rmvb|.wmv|.flv|.f4v|.vob|.mpg|.mkv|.3gp|.rm";
            var sourceList = FileHelper.FindFiles(path,pattern);
            VideoItems items = new VideoItems();
            if(items!=null)
            {
                foreach (var v in sourceList)
                {
                    items.Add(new VideoItem { Path=v});
                }
            }
            return items;
        }
    }
}
