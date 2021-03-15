using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodRecipes.Models;

namespace FoodRecipes.Data
{
    public class FoodRecipesContext : DbContext
    {
        public FoodRecipesContext (DbContextOptions<FoodRecipesContext> options)
            : base(options)
        {
        }

        public DbSet<FoodRecipes.Models.Ingredient> Ingredient { get; set; }
    }
}
