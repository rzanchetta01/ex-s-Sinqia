using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiAutomovel.Data;
using ApiAutomovel.Models;

namespace ApiAutomovel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomoveisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AutomoveisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Automoveis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Automovel>>> GetAutomeveis()
        {
            return await _context.Automeveis.ToListAsync();
        }

        // GET: api/Automoveis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Automovel>> GetAutomovel(int id)
        {
            var automovel = await _context.Automeveis.FindAsync(id);

            if (automovel == null)
            {
                return NotFound();
            }

            return automovel;
        }

        // PUT: api/Automoveis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutomovel(int id, Automovel automovel)
        {
            if (id != automovel.Id)
            {
                return BadRequest();
            }

            _context.Entry(automovel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovelExists(id))
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

        // POST: api/Automoveis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Automovel>> PostAutomovel(Automovel automovel)
        {
            _context.Automeveis.Add(automovel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutomovel", new { id = automovel.Id }, automovel);
        }

        // DELETE: api/Automoveis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutomovel(int id)
        {
            var automovel = await _context.Automeveis.FindAsync(id);
            if (automovel == null)
            {
                return NotFound();
            }

            _context.Automeveis.Remove(automovel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutomovelExists(int id)
        {
            return _context.Automeveis.Any(e => e.Id == id);
        }
    }
}
