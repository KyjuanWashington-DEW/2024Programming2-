using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DEWsBatsOfBrackenCave
{
    public class Shopkeep : Player
    {
        public List<Item> ShopInventory { get; private set; }

        public Shopkeep()
        {
         
            ShopInventory = new List<Item>
        {
            new Item("Owl Repellant", 15) { Amount = 15 },
            new Item("Fox Repellant", 20) { Amount = 20 },
            new Item("Snake Repellant", 25) { Amount = 22 }
        };
        }

        public string DisplayShopInventory()
        {
            StringBuilder shopItems = new StringBuilder();
            shopItems.AppendLine("Shop Items:");
            int index = 1;

            foreach (var item in ShopInventory)
            {
                shopItems.AppendLine($"{index}. {item.Name} - ${item.Value} (In Stock: {item.Amount})");
                index++;
            }

            return shopItems.ToString();
        }


        public bool SellItem(string itemName, Player player)
        {
            var item = ShopInventory.FirstOrDefault(i => i.Name == itemName);

            if (item != null && item.Amount > 0)
            {
                if (player.Money >= item.Value)
                {
                    player.Money -= item.Value;  
                    item.Amount--;              
                    return true;                
                }
                else
                {
                    MessageBox.Show("Player does not have enough money.");
                }
            }
            else
            {
                MessageBox.Show("Item is out of stock.");
            }

            return false;
        }
    }

}
