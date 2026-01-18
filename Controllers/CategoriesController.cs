using Microsoft.AspNetCore.Mvc;
using bt.Core.Entities;
using bt.Core.Interfaces;

namespace bt.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _service;
    public CategoriesController(ICategoryService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _service.GetCategoriesAsync());

    [HttpPost]
    public async Task<IActionResult> Create(Category entity)
    {
        await _service.CreateCategoryAsync(entity);
        return Ok(entity);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _service.GetCategoryByIdAsync(id);
        return result != null ? Ok(result) : NotFound();
    }
}