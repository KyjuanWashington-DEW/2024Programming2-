using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystemDew2024Fall
{
    //When the player encounters a creature it will print to the screen the name of the creature.
    //how many arms,legs,eyes,tails, and teeth it has and if it is big, medium, or small.
    //an override for the watercreatures is for the arms. they will be called fins. 
    //for skycreatures they will be called wings

    public class World
    {
       
       public World()
        {
            
            creatures = new List<Creature>();
        }
        public class Creature
        {
            public string Name { get; set; }
            public int Arms { get; set; }
            public int Legs { get; set; }
            public int Eyes { get; set; }
            public int Tails { get; set; }
            public string Size { get; set; }
            public int Wings { get; set; }
            public int Flippers { get; set; }

            public Creature(string name, int arms, int legs, int eyes, int tails, string size, int wings, int flippers)
            {
                Name = name;
                Arms = arms;
                Legs = legs;
                Eyes = eyes;
                Tails = tails;
                Size = size;
                Wings = wings;
                Flippers = flippers;
                
            }


            //base class must be virtual so it can be overidden by derived classes.
            public virtual string GetDescription()
            {
                return $"{Name} has {Arms} arms, {Legs} legs, {Eyes} eyes, {Tails} tails, and is {Size} sized.";
            }
        }

        public List<Creature> creatures;

        
        //the word has the ability to add more creatures when you find them.
        public void AddCreature(Creature creature)
        {
            creatures.Add(creature);
        }


        //Bestiary to show all creatures found in the world.
        public void ShowCreatures()
        {
            Console.WriteLine($"Creatures Discovered:" + creatures.Count());

            Console.WriteLine("Creatures in the world:");
            foreach (var creature in creatures)
            {
               
                Console.WriteLine(creature.GetDescription());
                
            }
        }
    }
}