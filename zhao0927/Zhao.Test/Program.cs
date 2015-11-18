using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zhao.Repository;
using Zhao.Domain;

namespace Zhao.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFDbContext db = new EFDbContext())
            {
                Catalog category = new Catalog {  CatalogName = "社区新闻" };
                db.Catalog.Add(category);

                
                Product product = new Product { CategoryID = category.CategoryID, ProductName = "IPhone5", UnitPrice = 5000m, Quantity = 100, UnitsInStock = 60 };
                db.Products.Add(product);

                db.SaveChanges();
            }
        }
    }
}
