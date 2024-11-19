using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystemDew2024Fall
{

    public class Engine
    {
        GameEnvironment gameEnvironment = new GameEnvironment();
      
        public void Start()
        {
        

           
          

            gameEnvironment.GameEnvironment1(gameEnvironment.person.PersonName, gameEnvironment.person.Currency);
        }

        public void Print(string message)

        {
            Console.WriteLine(message);
        }


    }
}



//I UNDERSTAND THAT PRINT ALLOWS ME TO TURN A STRING MESSAGE INTO A REUSABLE ITEM BUT
//WHAT IS TITLE And WHY DOES IT WORK IN THIS WAY Without Being A Defined Method?


////Title = Name;










//}







