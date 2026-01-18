using bt.Core.Entities;
using bt.Core.Interfaces;

namespace bt.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repo;
    public CategoryService(ICategoryRepository repo) => _repo = repo;

    public async Task<IEnumerable<Category>> GetCategoriesAsync() => await _repo.GetAllAsync();
    public async Task<Category?> GetCategoryByIdAsync(int id) => await _repo.GetByIdAsync(id);
    public async Task CreateCategoryAsync(Category entity) => await _repo.AddAsync(entity);
}
