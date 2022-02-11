using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project3.Server.Data;
using Project3.Shared.Domain;

namespace Project3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravellersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TravellersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Travellers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Traveller>>> GetTravellers()
        {
            return await _context.Travellers.ToListAsync();
        }

        // GET: api/Travellers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Traveller>> GetTraveller(int id)
        {
            var traveller = await _context.Travellers.FindAsync(id);

            if (traveller == null)
            {
                return NotFound();
            }

            return traveller;
        }

        // PUT: api/Travellers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTraveller(int id, Traveller traveller)
        {
            if (id != traveller.ID)
            {
                return BadRequest();
            }

            _context.Entry(traveller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravellerExists(id))
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

        // POST: api/Travellers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Traveller>> PostTraveller(Traveller traveller)
        {
            _context.Travellers.Add(traveller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTraveller", new { id = traveller.ID }, traveller);
        }

        // DELETE: api/Travellers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTraveller(int id)
        {
            var traveller = await _context.Travellers.FindAsync(id);
            if (traveller == null)
            {
                return NotFound();
            }

            _context.Travellers.Remove(traveller);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravellerExists(int id)
        {
            return _context.Travellers.Any(e => e.ID == id);
        }
    }
}
