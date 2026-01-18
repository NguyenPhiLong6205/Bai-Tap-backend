using Microsoft.EntityFrameworkCore;
using bt.Core.Entities;
using bt.Core.Interfaces;
using bt.Infrastructure.Data;

namespace bt.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;
    public CategoryRepository(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Category>> GetAllAsync() => await _context.Categories.ToListAsync();
    public async Task<Category?> GetByIdAsync(int id) => await _context.Categories.FindAsync(id);
    public async Task AddAsync(Category entity)
    {
        _context.Categories.Add(entity);
        await _context.SaveChangesAsync();
    }
}
