using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        
        public Recipe() { }

        public Recipe(int id)
        {
            Id = id;
        }

        public void AddRecipe(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }

}
