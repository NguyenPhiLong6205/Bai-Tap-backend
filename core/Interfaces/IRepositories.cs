using bt.Core.Entities;

namespace bt.Core.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(int id);
    Task AddAsync(Category entity);
}

public interface ITechnologyRepository
{
    Task<IEnumerable<Technology>> GetAllAsync();
    Task<Technology?> GetByIdAsync(int id);
    Task AddAsync(Technology entity);
    Task UpdateAsync(Technology entity);
    Task DeleteAsync(int id);
}
