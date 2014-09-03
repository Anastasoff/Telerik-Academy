namespace UsingOrderedBag
{
    using System;

    internal class Product : IComparable<Product>
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public decimal Price
        {
            get { return this.price; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
            {
                return -1;
            }
            if (this.Price < other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}