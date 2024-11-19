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
        public List<Recipe> RecipeRequirements { get; set; } = new List<Recipe>();


        public Recipe(string recipeName, double recipeAmount) // Constructor added
        {
            RecipeName = recipeName;
            RecipeAmount = recipeAmount;
        }
        public void AddRequirement(Recipe requirement) // Added method to add requirements
        {
            RecipeRequirements.Add(requirement);
        }

        //unnecessarry
        bool recipelistopen = false;
        public void RecipeList(bool recipelistopen, string CT, string SP)
        {
            recipelistopen = true;

        }
    }

}