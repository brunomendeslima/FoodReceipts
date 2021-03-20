using System.ComponentModel;

namespace FoodRecipes.Models
{
    public class Client
    {

        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Name { get; set; }
        [DisplayName("Telefone")]
        public string PhoneNumber { get; set; }

        public Client() { }

        public Client(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

    }
}
