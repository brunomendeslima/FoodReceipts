using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        [DisplayName("Preço Total")]
        public double TotalPrice { get; set; }

        public Order() { }

        public Order(Client client, double totalPrice)
        {
            Client = client;            
            TotalPrice = totalPrice;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
