using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystemDew2024Fall
{
    public class Utilities
    {
        static string credits = "~Game Produced By DEW~ \n ~Code Credits To DEW, and Janell B, Sally J~";
        static string death = "You Died, RISE AGAIN!";
        static string gameWon = "Congrats! You Actually Managed To Beat The Game!";
        static string gameOver = "Game Over. I Knew You Couldnt Do It...";

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Rollcredits()
        {
            Print(credits);
        }

        public string HUD(Person person)
        {
            return $"------------" + person.PersonName + "  Currency:" + person.Currency + "------------\n\n";
        }
        //////
        // Add item to collection
        public static void Adding(List<Item> items, Item itemName)
        {
            items.Add(itemName);
            Console.WriteLine($"{itemName.ItemName} has been added to your inventory.");
            Console.ReadKey();
        }

        // Remove item
        //Create separate method for crafting material removal
        
        public static void Remove(List<Item> list, int itemIndexNumber)
        {
            if (itemIndexNumber >= 0 && itemIndexNumber < list.Count)
            {
                string itemName = list[itemIndexNumber].ItemName;
                list.RemoveAt(itemIndexNumber);
                Console.WriteLine($"{itemName} has been removed from your inventory.");
            }
            else
            {

                Console.WriteLine("Nothing Gained, nothing lost");
            }
        }
        ////
        public static int SearchMaterial(List<Recipe> Materials, string recipeName )
        {
            for (int i = 0; i < Materials.Count; i++)
            {
                if (Materials[i].RecipeName == recipeName)
                    return i;
            }
            return -1; // Return -1 if the item is not found
        }

        ///
        // Search inventory
        public static int Search(List<Item> items, string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName == itemName)
                    return i;
            }
            return -1; // Return -1 if the item is not found
        }
    }

}

