using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CraftSystemDew2024Fall.World;
using static CraftSystemDew2024Fall.Utilities;

namespace CraftSystemDew2024Fall
{
    public class Locations
    {

        Random random = new Random();
        int RandomChance;
        bool Dragon;
        public World w = new World();
        public Item i = new Item();
       

        public Locations() { }

        public void Forest()
        {//add options in locations such as search
         //or modified bestiary with the player being able to look at area-specific creatures
         //Add Art To Depict The Location...
            Console.Clear();
            Console.WriteLine("Youve Entered The Forest");
            //add return statement as a utility
            Console.WriteLine("Press w to Go Forward.\nPress a to Go Left\nPress d to Go Right.");

            Console.WriteLine("Press b to Return to the OVERWORLD/MENU");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;
            if (key == 'w')
            {
                Console.WriteLine("You Went Forward");
                Console.ReadKey();

                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Bear");
                }
                else Forest();

            }
            if (key == 'a')
            {
                Console.WriteLine("You Went Left");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Bear");
                }
                else Forest();
            }
            if (key == 'd')
            {
                Console.WriteLine("You Went Right");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Bear");
                }
                else Forest();
            }
            else Forest();
            {
                Console.WriteLine("Invalid Entry, Try Again.");
            }

            if (key == 'b')
            {
                Console.Clear();
                Start.g.ShowMenu();
            }
        }

        //POKEYPOKETIME
        public void Hell()
        {
            //Add Art To Depict The Location...
            Console.Clear();
            Console.WriteLine("Youve Jumped Down To Hell");
            Console.WriteLine("Press w to Go Forward.\nPress a to Go Left\nPress d to Go Right.");

            Console.WriteLine("Press b to Return to the OVERWORLD/MENU");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;


            if (key == 'b')
            {
                Console.Clear();
                Start.g.ShowMenu();
            }

            if (key == 'w')
            {
                Console.WriteLine("You Went Forward");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Demon");
                }
                else { Hell(); }

            }
            if (key == 'a')
            {
                Console.WriteLine("You Went Left");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Demon");
                }
                else { Hell(); }
            }
            if (key == 'd')
            {
                Console.WriteLine("You Went Right");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Demon");
                }
                else { Hell(); }
            }
            else
            {
                Console.WriteLine("Invalid Entry, Try Again.");
            }
        }

        //Halo
        public void Heaven()
        {
            //Add Art To Depict The Location...
            Console.Clear();
            Console.WriteLine("Youve Ascended To Heaven");
            Console.WriteLine("Press w to Go Forward.\nPress a to Go Left\nPress d to Go Right.");


            Console.WriteLine("Press b to Return to the OVERWORLD/MENU");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;


            if (key == 'b')
            {
                Console.Clear();
                Start.g.ShowMenu();
            }

       
            if (key == 'w')
            {
                Console.WriteLine("You Went Forward");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Angel");
                }
                else { Heaven(); }

            }
            if (key == 'a')
            {
                Console.WriteLine("You Went Left");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Angel");
                }
                else { Heaven(); }
            }
            if (key == 'd')
            {
                Console.WriteLine("You Went Right");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Angel");
                }
                else { Heaven(); }
            }
            else
            {
                Console.WriteLine("Invalid Entry, Try Again.");
            }
        }

        //FISHEYTIME
        public void Ocean()
        {
            //Add Art To Depict The Location...
            Console.Clear();
            Console.WriteLine("Youve Dived Into The Ocean");
            Console.WriteLine("Press w to Go Forward.\nPress a to Go Left\nPress d to Go Right.");


            Console.WriteLine("Press b to Return to the OVERWORLD/MENU");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;


            if (key == 'b')
            {
                Console.Clear();
                Start.g.ShowMenu();
            }

            if (key == 'w')
            {
                Console.WriteLine("You Swam Forward");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Leviathan");
                }
                else Ocean();

            }
            if (key == 'a')
            {
                Console.WriteLine("You Swam Left");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Leviathan");
                }
                else Ocean();
                
            }
            if (key == 'd')
            {
                Console.WriteLine("You Swam Right");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Leviathan");
                }
                else Ocean();
            }
            else
            {
                Console.WriteLine("Invalid Entry, Try Again.");
            }

        }

   //DRAGONS
        public void Dragonkeep()
        {
            Dragon = true;


            //Add Art To Depict The Location...
            Console.Clear();
            Console.WriteLine("Youve Tresspased Into The Domain Of The Dragons. The DRAGONKEEP");
            Console.WriteLine("Press w to Go Forward.\nPress a to Go Left\nPress d to Go Right.");
            Console.WriteLine("Press b to Return to the OVERWORLD/MENU");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;


            if (key == 'b')
            {
                Console.Clear();
                Start.g.ShowMenu();
            }

            if (key == 'w')
            {
                Console.WriteLine("You Went Forward");
                Console.ReadKey();
                RandomChance = random.Next(1,9);
                if (RandomChance == 8)
                {
                    Moved("Dragon");
                }
                else { }
              
            }
            if (key == 'a')
            {
                Console.WriteLine("You Went Left");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Dragon");
                }
                else { }
            }
            if (key == 'd')
            {
                Console.WriteLine("You Went Right");
                Console.ReadKey();
                RandomChance = random.Next(1, 9);
                if (RandomChance == 8)
                {
                    Moved("Dragon");
                }
                else { Console.WriteLine("YOU GOT LOST "); }
            }
            else 
                    {
                Console.WriteLine("Invalid Entry, Try Again.");
            }


        }

        public void Battle()
        {

        }
        public void Moved(string Creatures)
        {
            
            switch (Creatures)
            {
                case "Bear":
             
                    LandCreature bear = new LandCreature("Great Rune Bear", 2, 2, 2, 1, "large", 0, 0);
                    w.AddCreature(bear); // Add the bear to the world
                    Console.WriteLine("You've encountered a GREAT RUNE BEAR!");
                    Console.WriteLine(bear.GetDescription());
                    Console.ReadKey();
                    //remove return to menu and add battle logic
                    Start.g.ShowMenu();
                    break;
                case "Demon":
                    LandCreature Azathon = new LandCreature("Azathon: Lord of Sin", 6, 2, 14, 1, "Gigantic", 6, 0);
                    w.creatures.Add(Azathon); // Add the bear to the world
                    Console.WriteLine("You've encountered a GREAT Demon");
                    Console.WriteLine(Azathon.GetDescription());
                    Console.ReadKey();
                    //remove return to menu and add battle logic
                    Start.g.ShowMenu();
                    break;
                case "Angel":
                    SkyCreature Mettatron = new SkyCreature("Mettatron: The Right Hand", 2, 2, 2, 0, "large", 2, 0);
                    w.creatures.Add(Mettatron); // Add the bear to the world
                    Console.WriteLine("You Stand Before Mettatron; The Right Hand Of The Lord Of Hosts!");
                    Console.WriteLine(Mettatron.GetDescription());
                    Item Grace = new Item("Holy Grace", 1, 1000);
                    Adding(Start.g.person.Inventory,Grace);
                    i.ViewItems();
                    Console.ReadKey();
                    //Console.WriteLine(Mettatron.Name);
                    //remove return to menu and add battle logic
                    Start.g.ShowMenu();
                    break;
                case "Leviathan":
                    WaterCreature Leviathan = new WaterCreature("Leviathan", 0, 0, 2, 1, "Gigantic", 0, 0);
                    w.creatures.Add(Leviathan); // Add the bear to the world
                    Console.WriteLine("You've encountered The Ancient Sea Serpent The LEVIATHAN!");
                    Console.WriteLine(Leviathan.GetDescription());
                    Console.ReadKey();
                    //remove return to menu and add battle logic
                    Start.g.ShowMenu();
                    break;
                case "Dragon":
                    SkyCreature LavaDragon = new SkyCreature("Infernal Dragon", 2, 2, 2, 1, "large", 2, 0);
                    w.creatures.Add(LavaDragon); // Add the bear to the world
                    Console.WriteLine("You've encountered THE INFERNAL DRAGON!");
                    Console.WriteLine(LavaDragon.GetDescription());
                    Console.ReadKey();
                    //remove return to menu and add battle logic
                    Start.g.ShowMenu();
                    break;
            }


        }
    }
}
