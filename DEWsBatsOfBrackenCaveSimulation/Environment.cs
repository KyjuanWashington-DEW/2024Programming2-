using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsBatsOfBrackenCave
{
    public class Environment
    {
        public int AreaTemp { get; set; }
        public string Location { get; set; }

        public Environment(int areaTemp, string location)
        {
            AreaTemp = areaTemp;
            Location = location;
        }
    }
}
