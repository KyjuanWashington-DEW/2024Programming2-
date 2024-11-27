using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsBatsOfBrackenCave
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Money { get; set; }
        public Player() 
        {
            PlayerName = "";
            Money = 1000;
        }
        
    }
}
