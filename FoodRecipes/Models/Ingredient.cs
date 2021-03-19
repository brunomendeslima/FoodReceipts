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
        [DisplayName("Preço de compra")]
        public double BuyPrice { get; set; }
        [DisplayName("Quantidade comprada")]
        public int QuantityBuy { get; set; }
        [DisplayName("Quantidade na receita")]
        public int QuantityInRecipe { get; set; }
        [DisplayName("Custo na receita")]
        public double PriceInRecipe { get; set; }

        public Ingredient() { }

        public Ingredient(int id, string name, double buyPrice, int quantityBuy, int quantityInRecipe, double priceInRecipe)
        {
            Id = id;
            Name = name;
            BuyPrice = buyPrice;
            QuantityBuy = quantityBuy;
            QuantityInRecipe = quantityInRecipe;
            PriceInRecipe = priceInRecipe;
        }

        public double GetPriceInRecipe() 
        {
            PriceInRecipe = (BuyPrice / QuantityBuy) * QuantityInRecipe;
            return PriceInRecipe;
        }
    }
}
