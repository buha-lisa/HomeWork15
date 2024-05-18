
namespace hw15
{
    class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ShopType { get; set; }

        public Shop() { }

        ~Shop()
        {
            Console.WriteLine($"The shop '{Name}' from '{Address}' is being destroyed.");
        }

        public void Dispose() { }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {ShopType}");
        }
    }
}
