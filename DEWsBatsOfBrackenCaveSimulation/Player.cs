using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace DEWsBatsOfBrackenCave
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Money { get; set; }
     public   Item owlRepellant = new Item("Owl Repellant", 15) { Amount = 5 };
       public Item foxRepellant = new Item("Fox Repellant", 20) { Amount = 5 };
      public  Item snakeRepellant = new Item("Snake Repellant", 25) { Amount = 5 };

      

        public Player()
        {
            PlayerName = "";
            Money = 1000;
        
            

        }

     
          

      
      public void UseItem(Item name)
        {


            if (name.Amount == 0)
            {
                MessageBox.Show("You Dont Have Enough Of That");
            }
            if (name.Amount  > 0)
            { 
            name.Amount--;

                
                
                    MessageBox.Show($"{name.Name}:Used Remaining:{name.Amount}");
                
            }
        }

        //Simplify showing
        //public string DisplayInventory()
        //{
        //    string inventoryDisplay = "Player Inventory:\n";
        //    foreach (var kvp in Inventory)
        //    {
        //        inventoryDisplay += $"{kvp.Key.Name}: {kvp.Value} units\n";
        //    }
        //    return inventoryDisplay;
        //}

      
    }
}

