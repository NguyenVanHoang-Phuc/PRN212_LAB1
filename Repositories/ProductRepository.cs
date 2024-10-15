﻿using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void SaveProduct(Product p) => ProductDAO.Instance.SaveProduct(p);
        public void DeleteProduct(Product p) => ProductDAO.Instance.DeleteProduct(p);
        public void UpdateProduct(Product p) => ProductDAO.Instance.UpdateProduct(p);
        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();
        public Product GetProductById(int id) => ProductDAO.Instance.GetProductByID(id);
        public int GetMaxProductID() => ProductDAO.Instance.GetMaxProductID();
    }
}
