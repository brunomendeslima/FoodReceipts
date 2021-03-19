namespace FoodRecipes.Models
{
    public class Client
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Client() { }

        public Client(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

    }
}
