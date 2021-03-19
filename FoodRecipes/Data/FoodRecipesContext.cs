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

        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
