namespace LLSDK.Xml
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;

    /// <summary>
    /// to provide common xml operation
    /// xpath syntax: for example:"/Data/Area[@ID='1001']"
    /// </summary>
    public class XmlHelper
    {
        private static XmlDocument doc = new XmlDocument();
        private static string xmlpath = System.Windows.Forms.Application.StartupPath + @"\config.xml";
        static XmlHelper()
        {
            if (File.Exists(xmlpath))
                doc.Load(xmlpath);
        }
        /// <summary>
        /// 加载文件xml
        /// </summary>
        /// <param name="path"></param>
        public static void LoadXml(string path)
        {
            xmlpath =path;
            if (File.Exists(xmlpath))
                doc.Load(xmlpath);
        }
        /// <summary>
        /// Get a single Xml Node Attributes with xpath
        /// </summary>
        /// <param name="xpath">for example:"/Data/Area[@ID='1001']"</param>
        public static Dictionary<string, string> GetSingleNodeAttr(string xpath)
        {
            var root = doc.SelectSingleNode(xpath);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (XmlAttribute xa in root.Attributes)
            {
                dic.Add(xa.Name, xa.Value);
            }
            return dic;
        }
        /// <summary>
        /// 创建空白的Xml文件
        /// </summary>
        /// <param name="xmlpath"></param>
        /// <returns></returns>
        public static bool CreateBlankXml(string xmlpath="")
        {
            try
            {
                if(xmlpath=="") xmlpath= System.Windows.Forms.Application.StartupPath + @"\config.xml";
                FileStream fs = new FileStream(xmlpath, FileMode.OpenOrCreate);
                string msg = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<Data/>";
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();
                return true;
            }
            catch { return false; }
        }


        /// <summary>
        /// Insert a dictionary attrs into the given xml file with xpath
        /// </summary>
        /// <param name="xpath">Upper Node like /Data/</param>
        /// <param name="nodeName">need to be created</param>
        /// <param name="attributes">attrs dictionary</param>
        /// <param name="path">additional xml file path</param>
        public static void Insert(string xpath, string nodeName, Dictionary<string, string> attributes, string path = "")
        {
            if (path != "") xmlpath = path;
            LoadXml(xmlpath);
            var node = doc.CreateElement(nodeName);
            foreach (var item in attributes)
            {
                node.SetAttribute(item.Key, item.Value);
            }
            var parent = (XmlElement)doc.SelectSingleNode(xpath);
            parent.AppendChild(node);  
            doc.Save(xmlpath);
        }

        /// <summary>
        /// 移除指定xpath的节点
        /// </summary>
        /// <param name="xpath">for example:"/Data/Area[@ID='1001']"</param>
        /// <param name="path">set the operation xml file path</param>
        public static void Delete(string xpath, string path = "")
        {
            if (path != "") xmlpath = path;
            LoadXml(xmlpath);
            var node = doc.SelectSingleNode(xpath);
            var parent = node.ParentNode;
            parent.RemoveChild(node);
            doc.Save(xmlpath);
        }
        /// <summary>
        /// Through xpath to update the xml attributes
        /// </summary>
        /// <param name="xpath">for example:"/Data/Area"</param>
        /// <param name="dicAttribute">update the attr</param>
        /// <param name="path">xml file path</param>
        public static void Update(string xpath, Dictionary<string, string> dicAttribute, string path = "")
        {
            if (path != "") xmlpath = path;
            LoadXml(xmlpath);
            var node = doc.SelectSingleNode(xpath);
            foreach (var item in dicAttribute)
            {
                node.Attributes[item.Key].Value = item.Value;
            }
            doc.Save(xmlpath);
        }

        /// <summary>
        /// 更新当个节点的InnerText
        /// </summary>
        /// <param name="xpath">xpath like : /Data/[@id='1000']</param>
        /// <param name="value"></param>
        /// <param name="path">xml file path</param>
        public static void UpdateInnerText(string xpath, string value, string path = "")
        {
            if (path != "") xmlpath = path;
             LoadXml(xmlpath);
            var node = doc.SelectSingleNode(xpath);
            node.InnerText = value;
            doc.Save(xmlpath);
        }
        /// <summary>
        /// 获取单个节点的 Innertext
        /// </summary>
        /// <param name="xpath">xpath like : /Data/[@id='1000']</param>
        /// <param name="path">set xml file path</param>
        /// <returns></returns>
        public static string GetSingleNodeInnerText(string xpath, string path = "")
        {
            if (path != "") xmlpath = path;
              LoadXml(xmlpath);
            var node = doc.SelectSingleNode(xpath);
            return node.InnerText;
        }
    }
}
