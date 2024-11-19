using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystemDew2024Fall
{
    public class NPC : Person
    {
        public void BuyItem(Person player, string itemName)
        {
            int itemIndex = Utilities.SearchCollectionByName(this.Inventory, itemName);
            if (itemIndex != -1)
            {
                Item itemToBuy = this.Inventory[itemIndex];
                if (player.Currency >= itemToBuy.ItemValue)
                {
                    // Add item to player inventory
                    Utilities.Adding(player.Inventory, itemToBuy);
                    // Remove item from NPC inventory
                    Utilities.Remove(this.Inventory, itemIndex);
                    player.Currency -= itemToBuy.ItemValue;
                    this.Currency += itemToBuy.ItemValue;
                    Console.WriteLine($"{player.PersonName} bought {itemToBuy.ItemName} for {itemToBuy.ItemValue}.");
                }
                else
                {
                    //add art of a mean face
                    Console.WriteLine("Looks like youre low on funds chump.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, I Dont have it..");
            }
        }
    }

}
