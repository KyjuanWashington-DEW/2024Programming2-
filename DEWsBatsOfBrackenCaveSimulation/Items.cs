using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsBatsOfBrackenCave
{
    using System;
    using System.Collections.Generic;

    namespace DEWsBatsOfBrackenCave
    {
        public class Item
        {
            public string Name { get; set; }  
            public int Value { get; set; }   

            
            public static List<Item> Items = new List<Item>();

            
            public Item(string name, int value)
            {
                Name = name;
                Value = value;
                
                Items.Add(this);
            }

            public void ShowItem()
            {
                //$"Item: {Name}, Value: {Value}";
            }

         
        }
    }

}
