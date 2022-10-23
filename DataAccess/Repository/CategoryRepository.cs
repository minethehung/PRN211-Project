using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(string categoryName) => CategoryDAO.Instance.AddCategory(categoryName);

        public CategoryObject GetCategoryById(int categoryId) => CategoryDAO.Instance.GetCategoryById(categoryId);

        public CategoryObject GetCategoryByName(string categoryName) => CategoryDAO.Instance.GetCategoryByName(categoryName);

        public List<CategoryObject> GetCategoryList() => CategoryDAO.Instance.GetCategoryList();
    }
}
