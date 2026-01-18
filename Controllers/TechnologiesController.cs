using Microsoft.AspNetCore.Mvc;
using bt.Core.Entities;
using bt.Core.Interfaces;

namespace bt.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TechnologiesController : ControllerBase
{
    private readonly ITechnologyService _service;
    public TechnologiesController(ITechnologyService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _service.GetTechnologiesAsync());

    [HttpPost]
    public async Task<IActionResult> Create(Technology technology)
    {
        await _service.AddTechnologyAsync(technology);
        return Ok(technology);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var res = await _service.GetTechnologyByIdAsync(id);
        return res != null ? Ok(res) : NotFound();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Technology technology)
    {
        if (id != technology.Id) return BadRequest();
        await _service.UpdateTechnologyAsync(id, technology);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteTechnologyAsync(id);
        return NoContent();
    }
}