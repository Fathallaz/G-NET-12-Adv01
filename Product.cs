using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } = 10.00m;
        //public Product(int id, string name, decimal price)
        //{
        //    Id = id;
        //    Name = name;
        //    Price = price;
        //}
        public override string ToString()
        {
            return Name;
        }

    }
}
