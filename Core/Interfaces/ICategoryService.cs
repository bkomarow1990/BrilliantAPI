using Core.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        Task AddCategory(CategoryDTO category);
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        Task<CategoryDTO> GetCategoryById(int id);
        Task EditCategory(CategoryDTO category);
        Task DeleteCategoryById(int id);
    }
}
