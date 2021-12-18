using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bestoTech.Server.Data;
using bestoTech.Shared.Domain;

namespace bestoTech.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AStoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AStoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AStores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AStore>>> GetAStores()
        {
            return await _context.AStores.ToListAsync();
        }

        // GET: api/AStores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AStore>> GetAStore(int id)
        {
            var aStore = await _context.AStores.FindAsync(id);

            if (aStore == null)
            {
                return NotFound();
            }

            return aStore;
        }

        // PUT: api/AStores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAStore(int id, AStore aStore)
        {
            if (id != aStore.Id)
            {
                return BadRequest();
            }

            _context.Entry(aStore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AStoreExists(id))
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

        // POST: api/AStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AStore>> PostAStore(AStore aStore)
        {
            _context.AStores.Add(aStore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAStore", new { id = aStore.Id }, aStore);
        }

        // DELETE: api/AStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAStore(int id)
        {
            var aStore = await _context.AStores.FindAsync(id);
            if (aStore == null)
            {
                return NotFound();
            }

            _context.AStores.Remove(aStore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AStoreExists(int id)
        {
            return _context.AStores.Any(e => e.Id == id);
        }
    }
}
