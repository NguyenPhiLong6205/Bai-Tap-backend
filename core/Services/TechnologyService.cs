using bt.Core.Entities;
using bt.Core.Interfaces;

namespace bt.Core.Services;

public class TechnologyService : ITechnologyService
{
    private readonly ITechnologyRepository _repo;
    public TechnologyService(ITechnologyRepository repo) => _repo = repo;

    public async Task<IEnumerable<Technology>> GetTechnologiesAsync() => await _repo.GetAllAsync();
    public async Task<Technology?> GetTechnologyByIdAsync(int id) => await _repo.GetByIdAsync(id);
    public async Task AddTechnologyAsync(Technology technology) => await _repo.AddAsync(technology);
    
    public async Task UpdateTechnologyAsync(int id, Technology technology)
    {
        var existing = await _repo.GetByIdAsync(id);
        if (existing != null)
        {
            existing.Name = technology.Name;
            existing.Description = technology.Description;
            existing.ReleaseDate = technology.ReleaseDate;
            existing.CategoryId = technology.CategoryId;
            await _repo.UpdateAsync(existing);
        }
    }
    public async Task DeleteTechnologyAsync(int id) => await _repo.DeleteAsync(id);
}
