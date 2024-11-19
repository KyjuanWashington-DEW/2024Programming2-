using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Numerics;

namespace CraftSystemDew2024Fall


{
    //Honestly im about at my wits end with burnout here. It feels like that scene from Doctor Who were he was stuck in a
    //time prison and he had to hit a crystal wall on a loop for billions of years just to get out
    //except I can remember everything that happens in the loop.
    //Nevertheless If I can finish my animation work tomorrow morning I would hope to meet with you early before class.
    //I need help piecing together things. More specific problems.
    //its real discouraging sitting at a computer for 10 hours grasping at straws to piece together something barely cohenrent.

    public class Person
    {
        public List<Item> Inventory = new List<Item>();
        public string PersonName = "ANONYMOUS";
        public double Currency = 10.5;
        public string GameName = "DEW'S Crafting System";


        //I created the derived 
        public class Vendor : Person
        {
            public void ShowInvtory() { }
        }
        //Based on what you said a person  should have an inventory rather than the inventory being in thwe item class right? 
        public void ShowInventory()
        {
            //list of all collected items
            Console.WriteLine($"INVENTORY LIST\n---------------\n{Inventory}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();




            //Removed the switch case I had it There as an exit for the method. I'll guess it wasnt required. I cant test anything right now due to errors so i'll just write what I believe will work until I can get help.
            //new stuff at the bottom in trade method.



            //ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            //char key = keyInfo.KeyChar;


        }
        public void Print(string message)

        {
            Console.WriteLine(message);
        }
        public Person()
        {

            Console.WriteLine("HELLO and WELCOME TO \n");
            Print(GameName);
            Console.WriteLine("PRESS ENTER");
            Console.ReadKey();
            //input A System To Stop Invalid Answers
            Console.Clear();
            Console.WriteLine("Please Enter Your Name Then Press Enter");
            Console.WriteLine("");
            PersonName = Console.ReadLine();
            //input A System To Stop Invalid Answers
            Console.Clear();


            Console.WriteLine("Hello " + PersonName + "\n");
            Console.WriteLine("PRESS ENTER TO START THE GAME");
            Console.ReadKey();




        }


        ///This May be More correct/dynamic then the way I was trying to do it before
        public void Crafting(Recipe recipe)
        {
            bool hasIngredients = true;

            foreach (var ingredient in recipe.RecipeRequirements)
            {
                int itemIndex = Utilities.Search(Inventory, ingredient.RecipeName);
                if (itemIndex == -1 || Inventory[itemIndex].ItemAmount < ingredient.RecipeAmount)
                {
                    hasIngredients = false;
                    break;
                }
            }

            if (hasIngredients)
            {
                //Remove ingredients from inventory
                foreach (var ingredient in recipe.RecipeRequirements)
                {
                    int itemIndex = Utilities.Search(Inventory, ingredient.RecipeName);
                    Inventory[itemIndex].ItemAmount -= (int)ingredient.RecipeAmount;
                }

                //Add crafted item to inventory
                Utilities.Adding(Inventory, new Item { ItemName = recipe.RecipeName, ItemAmount = (int)recipe.RecipeAmount });
                Console.WriteLine($"You created {recipe.RecipeName}!");
            }
            else
            {
                Console.WriteLine("Sorry, You Need More Materials!");
            }
        }



        ////////Differe way


        //My Brain Started Working AWESOME. I Learned How To Reference Attributes From Other Classes and I kinda get the code structure a bit better. 

        public void Craft(bool recipelistopen, bool CraftingMenu, int SleepingPotion, int CupOfChamomileTea, int HalfTspLemonBalm, int HalfTspDriedLavender, int HalfTspAshwaganda, int CupOfWater, int TspChamomile, string CT, string SP)
        {
            //Im Sure There Is An Easier Way To Do This But I Just Dont Understand It Yet.

            //Add an entrypoint into the crafting menu from the main game then add options 1 - 9 to craft after a subsequent button press

            if (CupOfWater >= 1 && TspChamomile >= 1 && CraftingMenu == true)
            {
                --TspChamomile;
                --CupOfWater;

                //Gain What The Recipe Said Could Be Crafted
                ++CupOfChamomileTea;

                Console.WriteLine("You Made Some " + CT + "");

            }
            else
            {
                Console.WriteLine("Sorry, You Need More Materials!");
            }

            if (CupOfChamomileTea >= 1 && HalfTspAshwaganda >= 1 && HalfTspDriedLavender >= 1 && HalfTspLemonBalm >= 1 && CraftingMenu == true)
            {
                --CupOfChamomileTea;
                --HalfTspAshwaganda;
                --HalfTspDriedLavender;
                --HalfTspLemonBalm;

                //Gain What The Recipe Said Could Be Crafted

                ++SleepingPotion;

                Console.WriteLine("You Made A " + SP + "");


            }
            else
            {
                Console.WriteLine("Sorry, You Need More Materials!");
            }

            if (CupOfWater >= 1 && TspChamomile >= 1 && CraftingMenu == true)
            {


            }
            else
            {
                Console.WriteLine("Sorry, You Need More Materials!");
            }

        }
        public void Sell()
        {
            //Let player tell me what they want to buy 
            //show the player the vendors inventory items
            //does the player have the items price or greater currency
            //if not tell the player they dont have enough
            //if they have enough
            //find the item in the vendors inventory and -1 from the 
        }
        public void Harvest()
        {

        }

        //This holds Buying and selling 
        private void Trade()
        {

            Console.WriteLine("buy something and leave.");

            //let the player tell me what they want do

            Console.WriteLine("Press 1 To Buy, \n Press 2 To Sell");

            //show the player the shopkeep inventory items
            var keyOption = Console.ReadKey().KeyChar;

            // Check what the user pressed using a switch statement
            switch (keyOption)
            {
                case '1': //If 1
                    Console.WriteLine("\nYou chose to buy.");
                    //Call V Inventory
                    //interface printed to the console
                    Console.WriteLine(Vendor.ShowInventory());
                    Console.WriteLine("Enter the number of the item to buy");
                    string input = Console.ReadLine();
                    //when I create the inventory I want to add a for each statement to its print on the screen
                    //declaring that foreach item in inventory add string data of ascending numbers 1 through length


                    //Buying Logic
                    if (int.TryParse(input, out int number))
                    {
                        //checking inventory of vendor for numbers less than or equal to input, and input greter than 0
                        if (number > 0 && number <= Vendor.Inventory.Count)
                        {
                            //The only thing im confused about is if this way of doing things will be good in the longrun
                            //i believe this would work 100% if i knew why my Item class Datatypes arent being referenced.
                            //another thing that will help me is more 1 on 1 clarification. im okay with putting all this here
                            //because i am under the belief that i will 100%be able to create a list with data attached to it
                            //what i mean is that when i populate the inventorylist with items those items will have set currency
                            //values of int or double data type. aswell as string data attached like sword 50 read as sword 50$ on the console.
                            //You probably went over something similar and i probably did too.
                            //but as i stated before my memory is notoriously horrible and i need assistance.
                            var BoughtItem = Vendor.Inventory[number - 1];

                            double ItemPrice = BoughtItem.ItemValue;
                            //should I move the itemvalues here or is there an easy way to refernce it from the item class in this context?
                            //Item.Itemvalue?

                            //congruency of value player to prce
                            //Person.Currency would be redundant since im already in the class the currency data type exists in right?
                            if (Currency >= ItemPrice)
                            {
                                Currency -= ItemPrice;
                                Inventory.Add(BoughtItem);
                                //maybe just inventory is good for the player but i wonder why referencing the vendor's wont yield anything but errors
                                //
                                Console.WriteLine("Oh, You Bought Something. Good, Now Leave \n Press anything to leave the shop.");

                            }
                        }
                    }
                            break;




                case '2': //If 2
                    Console.WriteLine("\nYou chose to sell.");
                    //showing both inventories mainly because thats how i have seen it done in games  
                    //should i be so specific with person
                    Console.WriteLine($"{Vendor.ShowInventory()} \n {Person.ShowInventory()}"());
                    break;
                    //should put a case for when expression is invalid




            }
        }
    }
}

