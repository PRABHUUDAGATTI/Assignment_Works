using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class ProductRepost:IProductRepost
    {
        ProductDB _db;
        public ProductRepost(ProductDB db)
        {
            _db = db;
        }
        public void AddProduct(Product product)
        {
            
            _db.products.Add(product);
            _db.SaveChanges();
        }
        public void RemoveProduct(int ProductId)
        {
            var theater = _db.products.Find(ProductId);
            _db.products.Remove(theater);
            _db.SaveChanges();
        }
        public Product GetProduct(int ProductId)
        {
            return _db.products.Find(ProductId);
        }
        public IEnumerable<Product> GetProductList()
        {
            return _db.products.Include(obj=>obj.articles).Include(obj=>obj.SizeScale).ToList();
        }
        public void UpdateProduct(Product Product)
        {
            _db.Entry(Product).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
