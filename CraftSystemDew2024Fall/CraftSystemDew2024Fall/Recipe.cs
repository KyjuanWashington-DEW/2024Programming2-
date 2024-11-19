using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystemDew2024Fall
{

    public class Recipe
    {
        public string RecipeName { get; set; }
        public double RecipeAmount { get; set; }
        public double RecipeValue = 1;
        public string RecipeDescription;
        public string AmountType;
        public List<Recipe> Materials { get; set; } = new List<Recipe>();
        public Recipe() { }

        public Recipe(string recipeName, double recipeAmount, string recipeDescription) // Constructor added
        {
            RecipeName = recipeName;
            RecipeAmount = recipeAmount;
            RecipeDescription = recipeDescription;
        }
        //public void AddRequirement(Recipe requirement) // Added method to add requirements
        //{
        //    Materials.Add(requirement);
        //}
        public static void AddMaterial(List<Recipe> materials, Recipe recipeName)
        {
            materials.Add(recipeName);
        }

            //Recipe Book The player can collect in the Boon/Gift area
            public void RecipeBook1()
        {
            Console.WriteLine("You've Collected A Recipe Book There Should Be New Available Recipes In Your Recipe List Now");
            Recipe CupOfWater = new Recipe("Cup Of Water", 0, "A cup of Water. Useful for crafting potions" );
            AddMaterial(Start.g.person.MaterialInventory, CupOfWater);

            Recipe TspChamomile = new Recipe("Teaspoon Of Chamonile", 0, "A Teaspoon of Chamomile. Useful for crafting potions");
            AddMaterial(Start.g.person.MaterialInventory, TspChamomile);


            
           

        }
        public bool Boon = true; //for making the boons unclaimable again

        public void BoonMaterial1()
        {

            
                RecipeAmount += 4;
            
            Console.WriteLine("You've Receieved Many Materials");
            Console.ReadKey();
            Boon = false;
        }
        //Arguments test results in EXTREME Redundance.

        //Part of Arguments test
        //public void BoonMaterial1(List<Recipe> materials, Recipe recipeName)
        //{

        //    foreach (var recipe in materials)
        //    {
        //        recipe.RecipeAmount += 4;
        //    }
        //    Console.WriteLine("You've Receieved Many Materials");
        //    Console.ReadKey();
        //    Boon = false;
        //}


        // CupOfWater = 1;
        //    //public int TspChamomile = 1;
        //    //public int CupOfChamomileTea = 1;
        //    //public int HalfTspAshwaganda = 1;
        //    //public int HalfTspDriedLavender = 1;
        //    //public int HalfTspLemonBalm = 1;
        //    //public int SleepingPotion = 0;
        public void GetRecipeRequirements()
        {
            Console.WriteLine($"{RecipeName}:{RecipeAmount}\n{RecipeDescription}");

        }
        
        public void RecipeList()
        {
           // Console.WriteLine($"Materials Discovered:" + items.Count());

            Console.WriteLine("Recipes");
            foreach (var Recipe in Materials)
            {

               GetRecipeRequirements();

            }
        }

    }

}