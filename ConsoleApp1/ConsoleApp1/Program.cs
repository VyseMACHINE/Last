using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Item> item = new List<Item>
            {
            new Item
                {
               Title = "XML",
               Link = "https://habr.com/rss/interesting/",
               Description = "This XML file does not appear to have any style information associated with it. The document tree is shown below",
               PupDate = DateTime.Now
                }
            };           
            Console.ReadKey();
        }
    }
}
