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

    // GET api/parks
    [HttpGet]
    // public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string state, string type)
    public async Task<ActionResult<IEnumerable<Park>>> Get(ParkParameters parkParameters, string name, string state, string type)
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


      return await query
                    .Skip((parkParameters.PageNumber -1) * parkParameters.PageSize)
                    .Take(parkParameters.PageSize)
                    .ToListAsync();
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

    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // PUT: api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}