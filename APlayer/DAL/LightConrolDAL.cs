using APlayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace APlayer.DAL
{
    class LightConrolDAL
    {
        public static LightControl GetLights()
        {
            LightControl set = new LightControl();
            var attr = LLSDK.Xml.XmlHelper.GetSingleNodeAttr("/Data/Light");
            if (null != attr)
            {
                set.Enable = bool.Parse(attr["Enable"]);
                set.Address = attr["LightID"];
                set.NormState = attr["LightInit"];
                set.RemoteIP = attr["RemoteIP"];
                set.Ports =new List<string>(attr["LightPort"].Split(','));
                set.StrPorts = attr["LightPort"];
            }
            return set;
        }

        public static void UpdateLights(LightControl set)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Enable", set.Enable.ToString());
            dic.Add("LightID", set.Address);
            dic.Add("LightInit", set.NormState);
            dic.Add("RemoteIP", set.RemoteIP);
            dic.Add("LightPort", set.StrPorts);
            LLSDK.Xml.XmlHelper.Update("/Data/Light", dic);
        }
    }
}
