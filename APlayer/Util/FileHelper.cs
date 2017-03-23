using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace APlayer.Util
{
    class FileHelper
    {
        /// <summary>
        /// 按照搜索模式搜索相关的文件
        /// </summary>
        /// <param name="rootpath"></param>
        /// <param name="serachpattern">like:.jpg|.exe|.txt</param>
        /// <returns></returns>
        public static List<string> FindFiles(string rootpath, string serachpattern)
        {
            string[] fileTypes = serachpattern.Split('|', ',', ' ');
            var typelist = new List<string>(fileTypes);
            if (!Directory.Exists(rootpath)) return null;
                DirectoryInfo dirinfo = new DirectoryInfo(rootpath);
            var tmp = new List<FileInfo>(dirinfo.GetFiles());                          
            var list = tmp.FindAll(x=>typelist.Contains(x.Extension.ToLower())).ConvertAll(f=>f.FullName);
            list.Sort((x, y) => x.CompareTo(y));
            return list;           
        }
    }
}
