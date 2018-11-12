using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Item
    {
        public  string Title { get; set; } = ConfigurationSettings.AppSettings["pathXmlItem"].ToString();
        public  string Link { get; set; } = ConfigurationSettings.AppSettings["pathXmlItem"].ToString();
        public  string Description { get; set; } = ConfigurationSettings.AppSettings["pathXmlItem"].ToString();
        public DateTime PupDate { get; set; } 

        public static Item GetManDetails(string title, string Link, string Description)
        {
            Item item = new Item(); //потому что возвращаем тип Man

            XmlDataDocument xmlDoc = new XmlDataDocument();
            xmlDoc.Load(Title);
            XmlNode root = xmlDoc.DocumentElement;
            XmlNode node = root.SelectSingleNode(string.Format("Item[Title='{0}' Link='{1}' Description='{2}' ]", Title, Link, Description));

            XmlNodeList list = node.ChildNodes;

            for (int i = 0; i < list.Count; i++)
                item.[list.Item(i).Name] = list.Item(i).InnerText;

            return item;
        }
    }
}
