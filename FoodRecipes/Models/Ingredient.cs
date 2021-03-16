using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Name { get; set; }
        [DisplayName("Preço por KG")]
        public decimal PriceUnit { get; set; }
        [DisplayName("Quantidade")]
        public int Quantity { get; set; }
        [DisplayName("Custo na receita")]
        public decimal PriceInRecipe { get; set; }
    }
}
