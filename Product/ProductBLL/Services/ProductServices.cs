using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProductBLL.Services
{
    public class ProductServices
    {
        IProductRepost _IProductRepost;

        public ProductServices(IProductRepost IProductRepost)
        {
            _IProductRepost = IProductRepost;
        }
        public int initValue = 1;
        public double count2 = 100000000;
        public string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public void AddProduct(Product product)
        {
            if (product.channelId == 1)
            {



                product.productCode = (product.productYear * 100) + "" + initValue; 
            }
            else if (product.channelId == 2)
            {
                
                var stringChars = new char[6];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

               product.productCode = new String(stringChars);
            }
            else if(product.channelId == 3)
            {
                
                product.productCode = count2.ToString();
                count2++;
            }
          
            _IProductRepost.AddProduct(product);
        }
        public void UpdateProduct(Product Product)
        {
        
            _IProductRepost.UpdateProduct(Product);
        }
        public void DeleteProduct(int Id)
        {
            _IProductRepost.RemoveProduct(Id);
        }
        public Product GeProductById(int id)
        {
            return _IProductRepost.GetProduct(id);
        }
        public IEnumerable<Product> GetAll()
        {
            
           IEnumerable<Product> products= _IProductRepost.GetProductList();
           
            return products;
        }

    }
}
