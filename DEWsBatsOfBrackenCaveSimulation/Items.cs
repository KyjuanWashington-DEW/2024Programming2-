using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


 

    namespace DEWsBatsOfBrackenCave
    {
        public class Item
        {
            public string Name { get; set; }  
            public int Value { get; set; }

        public int Amount = 0;
            public static List<Item> Items = new List<Item>();

            
            public Item(string name, int value)
            {
                Name = name;
                Value = value;
                
                Items.Add(this);
            }
      

    

      

    public void ShowItem()
            {
  
            foreach (var item in Item.Items)
            {
                MessageBox.Show($"\n{item.Name}, Value: {item.Value}");
            }

        }

         
        }
    }


