using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CraftSystemDew2024Fall
{
    public class GameEnvironment
    {
        public Locations l = new Locations();
        public Person person = new Person();
        bool Gamestart = false;
        char key;

        public GameEnvironment() { }
    

        public void Goleft()
        {
            //add random logic here
        }
        public void Goright()
        {
            //add random logic here
        }

        public void ShowMenu()
        {
           

            Console.WriteLine("------------" + person.PersonName + "  Currency:" + person.Currency + "------------" +
                "\n\n\n\n\n" +
                "0.Boon"+
                "1.Inventory " +
                "2.Recipes " +
                "3.Shop " +
                "4.Explore " +
                "5.Bestiary " +
                "6.Quit");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;

            switch (key)
            {
                case '0':
                    person.Boon();
                    break;
                case '1':
                    person.ShowInventory();
                    break;
                case '2':
                    ShowRecipes();
                    break;
                case '3':
                    ShowShop();
                    break;
                case '4':
                    Explore();
                    break;
                case '5':
                    l.w.ShowCreatures();
                    Console.WriteLine("\n\n Press Any Key To Exit");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu();
                    break;
                case '6':
                    Console.WriteLine("Exiting the game...");
                    Rollcredits();

                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu();
                    break;
            }

        }
                
              

    

           

            //DO SOMETHING WITH THIS LATER
            //I Want To Add A Timer Till Game Starts
            //Timer CountdownTillStart
            //Gamestart = true;
            //while (Gamestart == true) 
            //{
            //}
        

        //Explore To Find Materials.
        //Movement Logic Goes Here



        //not working yet
        public void Rollcredits() 
        
        {
        
            Console.WriteLine("Game Made By DEW With Thanks To Janell B, and Sally J");
            Console.ReadKey();
            Console.Clear();
            ShowMenu();
        }

        public void ShowInventory()
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;

            switch (key)
            {
                case '1':
                    //person.Crafting();
                    break;


            }
        }
       

            public void ShowRecipes()
        {
            Console.Clear();
            Console.WriteLine("RECIPE BOOK.");//print a list of all craftable items.
            Console.WriteLine("\n\nPress Any Key To Exit");
            Console.ReadKey();
            ShowMenu();

        }


        public void ShowShop()
        {
            //replace with an array of random phrases make a phrase list then have it go through the phraselist count to get a random phrase
            Console.WriteLine("Welcome Ta Ma Shop. Buy Something Or Get Out!");
            Console.WriteLine("\n\nPress '1' to buy items.\npress '2' to sell items.");
            //Add in a Selection of vendor items and the logic to buy and sell.
            //add an exit method for each buy andsell logics.
            Console.WriteLine("\n\n Press Any Key To Exit");
            Console.ReadKey();
            ShowMenu();

        }



        public void Explore()
        {
            //Movement Logic
            Console.Clear();
            Console.WriteLine
                ("1. Search The Forest and Find Materials " +
                "\n2. Visit Hell " +
                "\n3. Visit Heaven " +
                "\n4. Go To The Ocean " +
                "\n5. Go To The Dragonkeep ");
            
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key2 = keyInfo.KeyChar;

            
           
            switch (key2)
            {
                case '1':
                        l.Forest();
                    break;
                case '2':
                    l.Hell();
                    break;
                case '3':
                    l.Heaven();
                    break;
                case '4':
                    l.Ocean();
                    break;
                case '5':
                    l.Dragonkeep();
                    break;
            }

        }

        

        //public override string ToString()




    }
}














//Test What If I Used Arguments

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace CraftSystemDew2024Fall
//{
//    public class GameEnvironment
//    {
//        public Locations l = new Locations();
//        public Person person = new Person();
//        bool Gamestart = false;
//        char key;

//        public GameEnvironment() { }


//        public void Goleft()
//        {
//            //add random logic here
//        }
//        public void Goright()
//        {
//            //add random logic here
//        }

//        public void ShowMenu(List<Recipe> materials, Recipe recipeName)
//        {


//            Console.WriteLine("------------" + person.PersonName + "  Currency:" + person.Currency + "------------" +
//                "\n\n\n\n\n" +
//                "0.Boon" +
//                "1.Inventory " +
//                "2.Recipes " +
//                "3.Shop " +
//                "4.Explore " +
//                "5.Bestiary " +
//                "6.Quit");

//            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//            char key = keyInfo.KeyChar;

//            switch (key)
//            {
//                case '0':
//                    person.Boon(materials, recipeName);
//                    break;
//                case '1':
//                    person.ShowInventory();
//                    break;
//                case '2':
//                    ShowRecipes(materials, recipeName);
//                    break;
//                case '3':
//                    ShowShop(materials, recipeName);
//                    break;
//                case '4':
//                    Explore();
//                    break;
//                case '5':
//                    l.w.ShowCreatures();
//                    Console.WriteLine("\n\n Press Any Key To Exit");
//                    Console.ReadKey();
//                    Console.Clear();
//                    ShowMenu(materials, recipeName);
//                    break;
//                case '6':
//                    Console.WriteLine("Exiting the game...");
//                    Rollcredits(materials, recipeName);

//                    return; // Exit the application
//                default:
//                    Console.WriteLine("Invalid option, please try again.");
//                    Console.ReadKey();
//                    Console.Clear();
//                    ShowMenu(materials, recipeName);
//                    break;
//            }

//        }







//        //DO SOMETHING WITH THIS LATER
//        //I Want To Add A Timer Till Game Starts
//        //Timer CountdownTillStart
//        //Gamestart = true;
//        //while (Gamestart == true) 
//        //{
//        //}


//        //Explore To Find Materials.
//        //Movement Logic Goes Here



//        //not working yet
//        public void Rollcredits(List<Recipe> materials, Recipe recipeName)

//        {

//            Console.WriteLine("Game Made By DEW With Thanks To Janell B, and Sally J");
//            Console.ReadKey();
//            Console.Clear();
//            ShowMenu(materials, recipeName);
//        }

//        public void ShowInventory()
//        {

//            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//            char key = keyInfo.KeyChar;

//            switch (key)
//            {
//                case '1':
//                    //person.Crafting();
//                    break;


//            }
//        }


//        public void ShowRecipes(List<Recipe> materials, Recipe recipeName)
//        {
//            Console.Clear();
//            Console.WriteLine("RECIPE BOOK.");//print a list of all craftable items.
//            Console.WriteLine("\n\nPress Any Key To Exit");
//            Console.ReadKey();
//            ShowMenu(materials, recipeName);

//        }


//        public void ShowShop(List<Recipe> materials, Recipe recipeName)
//        {
//            //replace with an array of random phrases make a phrase list then have it go through the phraselist count to get a random phrase
//            Console.WriteLine("Welcome Ta Ma Shop. Buy Something Or Get Out!");
//            Console.WriteLine("\n\nPress '1' to buy items.\npress '2' to sell items.");
//            //Add in a Selection of vendor items and the logic to buy and sell.
//            //add an exit method for each buy andsell logics.
//            Console.WriteLine("\n\n Press Any Key To Exit");
//            Console.ReadKey();
//            ShowMenu(materials, recipeName);

//        }



//        public void Explore()
//        {
//            //Movement Logic
//            Console.Clear();
//            Console.WriteLine
//                ("1. Search The Forest and Find Materials " +
//                "\n2. Visit Hell " +
//                "\n3. Visit Heaven " +
//                "\n4. Go To The Ocean " +
//                "\n5. Go To The Dragonkeep ");

//            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//            char key2 = keyInfo.KeyChar;



//            switch (key2)
//            {
//                case '1':
//                    l.Forest();
//                    break;
//                case '2':
//                    l.Hell();
//                    break;
//                case '3':
//                    l.Heaven();
//                    break;
//                case '4':
//                    l.Ocean();
//                    break;
//                case '5':
//                    l.Dragonkeep();
//                    break;
//            }

//        }



//        //public override string ToString()




//    }
//}
