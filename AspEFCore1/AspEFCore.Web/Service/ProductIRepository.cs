using AspEFCore.Model;
using AspEFCore.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspEFCore.Web.Service
{
    public class ProductIRepository : IRepository<Product>
    {
        private readonly DataContext _context;

        public ProductIRepository(DataContext context)
        {
            _context = context;
        }

       
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }
        public Product Add(Product newModel)
        {
            _context.Products.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public Product Update(int id, Product newModel)
        {

            var Product = _context.Products.Find(id);
            Product = newModel;
            _context.Products.Update(Product);
            _context.SaveChanges();
            
            return Product;
        }
        public Product Delete(int id)
        {
            var Product = _context.Products.Find(id);
            _context.Products.Remove(Product);
            _context.SaveChanges();

            return Product;
        }

    }
}
