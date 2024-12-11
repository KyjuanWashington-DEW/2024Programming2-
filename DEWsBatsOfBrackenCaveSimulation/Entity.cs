
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace DEWsBatsOfBrackenCave
{
    public class Entity
    {
        public string Animal { get; set; }
        public string Description { get; set; }
        public int Temp { get; set; }
        public int Population { get; set; }
        public int Irritation { get; set; }
        public int Makes { get; set; }
        public string MakesName { get; set; }

        public Entity(string animal, string description, int temp, int population, int irritation, int makes, string makesname)
        {
            Animal = animal;
            Description = description;
            Temp = temp;
            Population = population;
            Irritation = irritation;
            Makes = makes;
            MakesName = makesname;
        }
    }

    public class Prey : Entity
    {
       
        public Prey Bats { get; set; }

        public Prey(string animal, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(animal, description, temp, population, irritation, makes, makesname)
        {
        
     
        }

       
        public void IncreaseIrritation()
        {
            Irritation++;  
        }

        public void DecreasePopulation(int amount = 1)
        {
            Population -= amount;

            if (Population < 0)
            {
                Population = 0; 
            }
        }
    }



public class Predator : Entity
    {
        public Predator(string animal, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(animal, description, temp, population, irritation, makes, makesname)
        {


            Predator owl = new Predator(
                animal: "Owl",
                description: "A nocturnal bird of prey that hunts bats at night.",
                temp: 15,
                population: 50,
                irritation: 30,
                makes: 5,
                makesname: "Feathers"
            );

            Predator fox = new Predator(
                animal: "Fox",
                description: "A cunning predator that preys on bats anytime of day.",
                temp: 10,
                population: 40,
                irritation: 20,
                makes: 3,
                makesname: "Fur"
            );

            Predator snake = new Predator(
                animal: "Snake",
                description: "A stealthy predator that targets bats in caves during the day.",
                temp: 25,
                population: 60,
                irritation: 40,
                makes: 7,
                makesname: "Scales"
            );


            List<Predator> predators = new List<Predator> { owl, fox, snake };
            void PredatorInfoList()
            {


                foreach (var predator in predators)
                {
                    Console.WriteLine($"Name: {predator.Animal}");
                    Console.WriteLine($"Description: {predator.Description}");
                    Console.WriteLine($"Temperature Tolerance: {predator.Temp}");
                    Console.WriteLine($"Population: {predator.Population}");
                    Console.WriteLine($"Irritation Level: {predator.Irritation}");
                    Console.WriteLine($"Makes: {predator.Makes} {predator.MakesName}");
                    Console.WriteLine();
                }
            }

        }
    }

    public class Decomposer : Entity
    {
        public Decomposer(string animal, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(animal, description, temp, population, irritation, makes, makesname)
        {
        }
    }

    public class Vendor : Entity
    {
        public Vendor(string animal, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(animal, description, temp, population, irritation, makes, makesname)
        {
        }
    }

    public class Tourist : Entity
    {
        public Tourist(string animal, string description, int temp, int population, int irritation, int makes, string makesname)
            : base(animal, description, temp, population, irritation, makes, makesname)
        { //tourist make you money irritation level is affect by bats population being low
        }
    }
}
