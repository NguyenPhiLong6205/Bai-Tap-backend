using Microsoft.EntityFrameworkCore;
using bt.Core.Entities;
using bt.Core.Interfaces;
using bt.Infrastructure.Data;

namespace bt.Infrastructure.Repositories;

public class TechnologyRepository : ITechnologyRepository
{
    private readonly AppDbContext _context;
    public TechnologyRepository(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Technology>> GetAllAsync() => await _context.Technologies.ToListAsync();
    public async Task<Technology?> GetByIdAsync(int id) => await _context.Technologies.FindAsync(id);
    public async Task AddAsync(Technology entity)
    {
        _context.Technologies.Add(entity);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Technology entity)
    {
        _context.Technologies.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var st = await _context.Technologies.FindAsync(id);
        if (st != null) {
            _context.Technologies.Remove(st);
            await _context.SaveChangesAsync();
        }
    }
}
