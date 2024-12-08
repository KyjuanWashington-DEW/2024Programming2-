﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsBatsOfBrackenCave
{
    public class Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Temp { get; set; }
        public int Population { get; set; }
        public int Irritation { get; set; }
        public int Makes { get; set; }

        public string MakesName { get; set; }   

        public Entity(string name, string description, int temp, int population, int irritation, int makes, string makesname )
        {
            Name = name;
            Description = description;
            Temp = temp;
            Population = population;
            Irritation = irritation;
            Makes = makes;
            MakesName = makesname;
        }
    }

    public class Producer : Entity
    {
        public Producer(string name, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(name, description, temp, population, irritation, makes, makesname)
        {
        }
    }

    public class Consumer : Entity
    {
        public Consumer(string name, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(name, description, temp, population, irritation, makes,  makesname)
        {
        }
    }

    public class Decomposer : Entity
    {
        public Decomposer(string name, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(name, description, temp, population, irritation, makes,  makesname)
        {
        }
    }

    public class Vendor : Entity
    {
        public Vendor(string name, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(name, description, temp, population, irritation, makes, makesname)
        {
        }
    }

    public class Tourist : Entity
    {
        public Tourist(string name, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(name, description, temp, population, irritation, makes, makesname)
        {
        }
    }
}
