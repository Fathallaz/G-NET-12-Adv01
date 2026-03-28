using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products=new();
        public void Add(Product item)
        => _products.Add(item);


        public void Delete(int id)
        {
            var Product = GetById(id);
            _products.Remove(Product);
        }
        public IEnumerable<Product> GetAll()
        => _products;

        public Product GetById(int id)
        =>_products.Find(p => p.Id == id);
    }
}
