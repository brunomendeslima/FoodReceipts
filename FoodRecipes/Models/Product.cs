using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Models
{
    public class Product
    {
        public int ID { get; set; }
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public decimal SellPrice { get; set; }

        public Product() { }

        public Product(decimal sellPrice)
        {            
            SellPrice = sellPrice;
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }
    }
}
