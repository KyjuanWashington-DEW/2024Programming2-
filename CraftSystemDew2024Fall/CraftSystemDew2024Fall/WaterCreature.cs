﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CraftSystemDew2024Fall.World;

namespace CraftSystemDew2024Fall
{
    internal class WaterCreature : Creature
    {
        public WaterCreature(string name, int arms, int legs, int eyes, int tails, string size, int wings, int flippers)
             : base(name, arms, legs, eyes, tails, size, wings, flippers)
        {
            Name = name;
            Flippers = flippers;
            Legs = legs;
            Eyes = eyes;
            Tails = tails;
            Size = size;
        }

        public override string GetDescription()
        {
            if (Tails >= 2)

                return $"{Name} has {Arms} Arms, {Legs} legs, {Eyes} eyes, {Tails} tails, and is {Size} sized.";
            else
                return $"{Name} has {Arms} Arms, {Legs} legs, {Eyes} eyes, {Tails} tail, and is {Size} sized.";

        }
    }
}
