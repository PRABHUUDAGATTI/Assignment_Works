using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IProductRepost
    {
        void AddProduct(Product Product);
        Product GetProduct(int Productid);
        void RemoveProduct(int Productid);
        void UpdateProduct(Product Product);
        IEnumerable<Product> GetProductList();
    }
}
