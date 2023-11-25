using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkFinderAPI.Models;

namespace ParkFinderAPI.Controllers
{
  [Route("api/[Controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParkFinderAPIContext _db;
    public ParksController(ParkFinderAPIContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string state, string type)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }
      
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }


      return await query.ToListAsync();
    }

    // GET: api/Parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    // // POST api/animals
    // [HttpPost]
    // public async Task<ActionResult<Animal>> Post(Animal animal)
    // {
    //   _db.Animals.Add(animal);
    //   await _db.SaveChangesAsync();
    //   return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    // }

    // // PUT: api/Animals/5
    // [HttpPut("{id}")]
    // public async Task<IActionResult> Put(int id, Animal animal)
    // {
    //   if (id != animal.AnimalId)
    //   {
    //     return BadRequest();
    //   }

    //   _db.Animals.Update(animal);

    //   try
    //   {
    //     await _db.SaveChangesAsync();
    //   }
    //   catch (DbUpdateConcurrencyException)
    //   {
    //     if (!AnimalExists(id))
    //     {
    //       return NotFound();
    //     }
    //     else
    //     {
    //       throw;
    //     }
    //   }

    //   return NoContent();
    // }

    // private bool AnimalExists(int id)
    // {
    //   return _db.Animals.Any(e => e.AnimalId == id);
    // }

    // // DELETE: api/Animals/5
    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteAnimal(int id)
    // {
    //   Animal animal = await _db.Animals.FindAsync(id);
    //   if (animal == null)
    //   {
    //     return NotFound();
    //   }

    //   _db.Animals.Remove(animal);
    //   await _db.SaveChangesAsync();

    //   return NoContent();
    // }
  }
}