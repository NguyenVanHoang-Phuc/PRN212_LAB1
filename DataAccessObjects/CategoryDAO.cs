using System.Collections.Generic;
using BusinessObjects;

namespace DataAccessLayer

{
    public class CategoryDAO : SingletonBase<CategoryDAO>
    {
        public  List<Category> GetCategories()
        {
            var list = new List<Category>()
            {
                new Category{CategoryID=1, CategoryName="Beverages"},
                new Category{CategoryID=2, CategoryName="Condiments" },
                new Category{CategoryID=3, CategoryName="Confections" },
                new Category{CategoryID=4, CategoryName="Dairy Products"},
                new Category{CategoryID=5, CategoryName="Grains/Cereals"},
                new Category{CategoryID=6, CategoryName="Meat/Poultry"},
                new Category{CategoryID=7, CategoryName="Produce"},
                new Category{CategoryID=8, CategoryName="Seafood"}
            };
            return list;
        }
    }
}
