using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Numerics;
using System.Diagnostics;
using static CraftSystemDew2024Fall.Utilities;


namespace CraftSystemDew2024Fall


{
    
    public class Person
    {
        public List<Item> Inventory = new List<Item>();
        public List<Recipe> MaterialInventory = new List<Recipe>();
        public Recipe r;//May need to reference constructor with arguments
       
        public string PersonName = "ANONYMOUS";
        public double Currency = 10.5;
        public string GameName = "DEW'S Crafting System";
        public GameEnvironment G;

        //I created the derived 
        public class Vendor : Person
        {
            
        }

        public void Boon(/*List<Recipe> materials, Recipe recipeName*/) 
        {

            Console.WriteLine("You Have Been Gifted Items");
            Item Sword = new Item("Sword", 1, 1000);
            Adding(Start.g.person.Inventory, Sword);
            G.l.i.ViewItems();
            r.RecipeBook1();
            r.BoonMaterial1();/*(materials,recipeName);*/
        }

        //Based on what you said a person  should have an inventory rather than the inventory being in thwe item class right? 
        public void ShowInventory()
        {
            //list of all collected items
            Console.Clear();
            Console.WriteLine($"INVENTORY LIST\n---------------\n{Inventory}");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;

            switch (key)
            {
                case '1':
                   /* Crafting()*/;
                    break;


            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            //Why is this null
            G.ShowMenu();



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
      
        //Constructor
        public Person(List<Item> inventory, string personName, double currency, string gameName
            )
        {
            Inventory = inventory;
            PersonName = personName;
            Currency = currency;
            GameName = gameName;
           

    }

        //Make Another Crafting Method which May be simpler or just for practice

        //This May be More correct/dynamic then the way I was trying to do it before
        //REFACTOR/Rewrite SOON
        public void Crafting(Recipe recipe, Recipe RecipeName)
        {
            bool hasIngredients = true;

            foreach (var ingredient in recipe.Materials)
            {
                int RecipeIndex = Utilities.SearchMaterial(r.Materials, r.RecipeName); //Searching scope of material list in recipe and recipenames
                if (RecipeIndex == -1 || MaterialInventory[RecipeIndex].RecipeAmount < ingredient.RecipeAmount)
                {
                    hasIngredients = false;
                    Console.WriteLine("Sorry, No Crafting For You Buddy");
                    break;
                }
            }
           
            if (hasIngredients)
            {
                //Remove ingredients from inventory
                foreach (var ingredient in MaterialInventory)
                {
                    //int itemIndex = Utilities.Search(MaterialInventory, ingredient.RecipeName);
                    //MaterialInventory[itemIndex].ItemAmount -= (int)ingredient.RecipeAmount;
                }

                //Add crafted item to inventory

                Utilities.Adding(Inventory, new Item() { ItemName = recipe.RecipeName, ItemAmount = (int)recipe.RecipeAmount });
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
        private void Trade(Person person, Recipe recipe, Item itemName)
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
                    ShowInventory();
                    Console.WriteLine("Enter the number of the item to buy");
                    string input = Console.ReadLine();
                    //when I create the inventory I want to add a for each statement to its print on the screen
                    //declaring that foreach item in inventory add string data of ascending numbers 1 through length


                    //Buying Logic
                    if (int.TryParse(input, out int number))
                    {
                        //checking inventory of vendor for numbers less than or equal to input, and input greter than 0
                        if (number > 0 && number <= Inventory.Count)
                        {
                            //The only thing im confused about is if this way of doing things will be good in the longrun
                            //i believe this would work 100% if i knew why my Item class Datatypes arent being referenced.
                            //another thing that will help me is more 1 on 1 clarification. im okay with putting all this here
                            //because i am under the belief that i will 100%be able to create a list with data attached to it
                            //what i mean is that when i populate the inventorylist with items those items will have set currency
                            //values of int or double data type. aswell as string data attached like sword 50 read as sword 50$ on the console.
                            //You probably went over something similar and i probably did too.
                            //but as i stated before my memory is notoriously horrible and i need assistance.
                            var BoughtItem = Inventory[number - 1];

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
                    ShowInventory();
                    break;
                    //should put a case for when expression is invalid




            }
        }
    }
}

