using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        List<CategoryObject> GetCategoryList();
        CategoryObject GetCategoryById(int categoryId);
        CategoryObject GetCategoryByName(string categoryName);
        void AddCategory(string categoryName);
    }
}
