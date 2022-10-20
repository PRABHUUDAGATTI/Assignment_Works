using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL
{
    public class ProductDB: DbContext
    {
        public ProductDB(DbContextOptions<ProductDB> options) : base(options)
        {
        }
        public DbSet<Article> articles { get; set; }
        public DbSet<Colour> colours { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<SizeScale> sizeScales { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2156;Initial Catalog=Product_Database2; Integrated Security=true;");
        }
    }
}
