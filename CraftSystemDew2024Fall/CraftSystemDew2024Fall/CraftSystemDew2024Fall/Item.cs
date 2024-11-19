using CraftSystemDew2024Fall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystemDew2024Fall
{
    public class Item
    {
        //starting to realize get set and string interpolation are the best tools
        int ItemAmount { get; set; }
        int ItemValue { get; set; }
        string ItemName { get; set; }
        public string AmountType = "Beans";
        string[] items = new string[9];
       
        public Item(string itemName, int itemAmount, int itemValue) //Constructor
        {
            ItemName = itemName;
            ItemAmount = itemAmount;
            ItemValue = itemValue;
        }

        //make into list for more fluid system.

        //basically unnecessary now
        public void Items()
        {


            // Adding items to the array
            items[0] = "Health Potion";
            items[1] = "Mana Potion";
            items[2] = "Sword";
            items[3] = "Shield";
            items[4] = "Armor";
        }



    
    }
    //{

    //        public int Cost;
    //        public int ItemAmount;
    //        public string 

    //    ////Number Of Items Collected
    //    //public int CupOfWater = 1;
    //    //public int TspChamomile = 1;
    //    //public int CupOfChamomileTea = 1;
    //    //public int HalfTspAshwaganda = 1;
    //    //public int HalfTspDriedLavender = 1;
    //    //public int HalfTspLemonBalm = 1;
    //    //public int SleepingPotion = 0;


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
}
//}
