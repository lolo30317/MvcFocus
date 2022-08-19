using DataAccess.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> category = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return category.List();
        }
        public void Add(Category c)
        {
            if (c.CategoryName == "" || c.CategoryName.Length<=2 || c.CategoryDescription == "" || c.CategoryName.Length>=50)
            {
                //hata
            }
            else
            {
                category.Add(c);
            }
        }
    }
}
