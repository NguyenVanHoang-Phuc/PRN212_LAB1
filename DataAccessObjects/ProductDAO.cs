using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO : SingletonBase<ProductDAO>
    {
        List<Product> list;

        public ProductDAO()
        {
            list = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Chai", CategoryId=3, UnitsInStock=12, UnitPrice=18 },
                new Product{ProductId=2, ProductName="Chang", CategoryId=2, UnitsInStock=23, UnitPrice=19 },
                new Product{ProductId=3, ProductName="Aniseed Syrup", CategoryId=1, UnitsInStock=23, UnitPrice=10 }
            };
        }
        public List<Product> GetProducts() 
        {
            return list;
        }
        public int GetMaxProductID()
        {
            if(list.Count > 0)
            {
                return list.Max(x => x.ProductId) + 1;
            }
            else
            {
                return 0;
            }
        }
        public void SaveProduct(Product p)
        {
            list.Add(p);
        }

        public void UpdateProduct(Product p)
        {
            foreach(Product cr in list.ToList())
            {
                if(cr.ProductId ==  p.ProductId)
                {
                    cr.ProductId = p.ProductId;
                    cr.ProductName = p.ProductName;
                    cr.UnitPrice = p.UnitPrice;
                    cr.UnitsInStock = p.UnitsInStock;
                    cr.CategoryId = p.CategoryId;
                }
            } 
        }

        public void DeleteProduct(Product p)
        {
            foreach (Product cr in list.ToList())
            {
                if(cr.ProductId == p.ProductId)
                {
                    list.Remove(p);
                }
            }
        }

        public Product GetProductByID(int id)
        {
            foreach (Product cr in list.ToList())
            {
                if(cr.ProductId == id)
                {
                    return cr;
                }
            }
            return null;
        }

    }
}
