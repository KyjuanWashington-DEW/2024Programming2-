using CraftSystemDew2024Fall;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CraftSystemDew2024Fall.World;

namespace CraftSystemDew2024Fall
{//Give Me 1 Sec I have To join through my tablet My Phone Is Broken
    public class Item
    {
        public int ItemAmount { get; set; }
        public int ItemValue { get; set; }
        public string ItemName { get; set; }
        public string AmountType = "Beans";//forget what i was gonna use this for probably irrelevant 


        public Item()
        {
            items = new List<Item>();
        }

        public List<Item> items;
        public Item(string itemName, int itemAmount, int itemValue) //Constructor
        {
            ItemName = itemName;
            ItemAmount = itemAmount;
            ItemValue = itemValue;
        }


        //Turn these into public strings

        public virtual string GetItemDescription()
        {
            return $"{ItemName}:{ItemAmount} The Value Is *{ItemValue}";
        }
        public void ViewItems()
        {
            Console.WriteLine($"items Discovered:" + items.Count());

            Console.WriteLine("Items");
            foreach (var item in items)
            {

                Console.WriteLine(GetItemDescription());

            }
        }


        //$"{ItemName}:{ItemAmount}\nValue:{ItemValue}.";
    }
}




    
    //{

    //        public int Cost;
    //        public int ItemAmount;



    //    //Names Of Items Collected
    //    //private readonly string CW = "Cups Of Water";
    //    //private readonly string TC = "Teaspoons Of Chamomile";
    //    //public readonly string CT = "Cups Of Chamomile Tea";
    //    //public readonly string SP = "SleepingPotion";
    //    //private readonly string HTA = "Half Teaspoons Of Ashwaganda";
    //    //private readonly string HTDL = "Half Teaspoons Of Dried Lavender";
    //    //private readonly string HTLB = "Half Teaspoons Of Lemon Balm";
    //    //public void Itemlist()
    //    //{
    //    //    //

    //    //    //Plan To Add An Array So That I Can Pass It As An Argument If Possible To Create The Recipelist/book and another to standin for the shopkeepers shop.

//}
