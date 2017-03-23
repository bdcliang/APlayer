using APlayer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace APlayer.DAL
{
    class SettingDAL
    {
        public static Setting GetSetting()
        {
            Setting set = new Setting();
            var attr= LLSDK.Xml.XmlHelper.GetSingleNodeAttr("/Data/Window");
            if(null!=attr)
            {
                set.CirPlay = bool.Parse(attr["CirPlay"]);
                set.HideCur = bool.Parse(attr["HideCusor"]);
                set.TopMost= bool.Parse(attr["TopMost"]);
                set.Port = int.Parse(attr["Port"]);
                set.ClientRec =(Rectangle) new RectangleConverter().ConvertFromString(attr["Screen"]);
            }
            return set;
        }

        public static void UpdateSetting(Setting set)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("CirPlay",set.CirPlay.ToString());
            dic.Add("TopMost",set.TopMost.ToString());
            dic.Add("HideCusor",set.HideCur.ToString());
            dic.Add("Port",set.Port.ToString());
            var rec = set.ClientRec;
            dic.Add("Screen",string.Format("{0},{1},{2},{3}",rec.X,rec.Y,rec.Width,rec.Height));
            LLSDK.Xml.XmlHelper.Update("/Data/Window",dic);
        }
    }
}
