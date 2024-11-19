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
       
        public Person person = new Person();
        bool Gamestart = false;
        char key;

        public void Goleft()
        {
            //add random logic here
        }
        public void Goright()
        {
            //add random logic here
        }

        public void GameEnvironment1(string PersonName, double Currency )
        {


            Console.WriteLine("------------" + PersonName + "  Currency:" + Currency +
                "\n\n\n\n\n" +
                "1.Inventory " +
                "2.Recipes " +
                "3.Shop " +
                "4.Explore " +
                "5.Quit");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;

            switch (key)
            {
                case '1':
                    ShowInventory();
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
                    Rollcredits();
                    break;
                case '6':
                    Console.WriteLine("Exiting the game...");
                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break; }


                
              

    
            //I Dont Know How To Register The Enter Key As A Key To Press To Proceed I Was Going To Use An IF Statement To Say Press Enter And Any Other Key Else Is Going To Be Invalid. 
            //if (Console.ReadKey == )
            //Game In Action
            //Maybe Put The System In A While Statement With bool Geamstart

            //had to use some other code to Get This to work still dont understand it
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //char key = keyInfo.KeyChar;
            //

           

            //DO SOMETHING WITH THIS LATER
            //I Want To Add A Timer Till Game Starts
            //Timer CountdownTillStart
            //Gamestart = true;
            //while (Gamestart == true) 
            //{
            //}
        }

        //Explore To Find Materials.
        //Movement Logic Goes Here



        //not working yet
        public void Rollcredits() { }

        public void ShowInventory()
        {
           
        }


            public void ShowRecipes()
        {
            Console.WriteLine("RECIPE BOOK.");

        }


            public void ShowShop()
        {
            //replace with an array of random phrases 
            Console.WriteLine("Welcome Ta Ma Shop. Buy Something Or Get Out!");
           
        }



        public void Explore()
        {
            //Movement Logic

            Console.WriteLine("Search The Forest and Find Materials");
            Console.Read();
            if (key == 'a')
            {
                Goleft();
            }
            if (key == 'd')
            {
                Goright();
            }

        }

        

        //public override string ToString()




    }
}
