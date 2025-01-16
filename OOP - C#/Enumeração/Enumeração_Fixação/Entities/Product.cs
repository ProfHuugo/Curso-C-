namespace Course.Entities
{
    class Product
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        public Product()
        {

        }


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}