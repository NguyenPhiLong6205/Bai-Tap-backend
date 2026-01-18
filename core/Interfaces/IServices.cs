using bt.Core.Entities;

namespace bt.Core.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetCategoriesAsync();
    Task<Category?> GetCategoryByIdAsync(int id);
    Task CreateCategoryAsync(Category entity);
}

public interface ITechnologyService
{
    Task<IEnumerable<Technology>> GetTechnologiesAsync();
    Task<Technology?> GetTechnologyByIdAsync(int id);
    Task AddTechnologyAsync(Technology technology);
    Task UpdateTechnologyAsync(int id, Technology technology);
    Task DeleteTechnologyAsync(int id);
}
