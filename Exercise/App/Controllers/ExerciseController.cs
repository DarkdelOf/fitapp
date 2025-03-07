using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;

namespace App.Controllers;

[Route(template:"api/[controller]")]
[ApiController]
public class ExerciseController : ControllerBase
{
    private readonly DataContext _context;
    public ExerciseController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<List<ExerciseModel>>> Add(ExerciseModel exercise)
    {
        _context.Exercises.Add(exercise);
        await _context.SaveChangesAsync();
        
        return Ok(await _context.Exercises.ToListAsync());
    }

    [HttpGet]
    public async Task<ActionResult<List<ExerciseModel>>> GetAll()
    {
        return Ok(await _context.Exercises.ToListAsync());
    }
}