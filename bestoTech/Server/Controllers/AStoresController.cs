using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bestoTech.Server.Data;
using bestoTech.Shared.Domain;
using bestoTech.Server.IRepository;

namespace bestoTech.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AStoresController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public AStoresController(ApplicationDbContext context)
        public AStoresController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/AStores
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<AStore>>> GetAStores()
        public async Task<IActionResult> GetAStores()
        {
            //return await _context.AStores.ToListAsync();
            var aStores = await _unitOfWork.AStores.GetAll();
            return Ok(aStores);
        }

        // GET: api/AStores/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<AStore>> GetAStore(int id)
        public async Task<IActionResult> GetAStore(int id)
        {
            //var aStore = await _context.AStores.FindAsync(id);
            var aStore = await _unitOfWork.AStores.Get(q => q.Id == id);

            if (aStore == null)
            {
                return NotFound();
            }

            //return aStore;
            return Ok(aStore);
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

            //_context.Entry(aStore).State = EntityState.Modified;
            _unitOfWork.AStores.Update(aStore);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!AStoreExists(id))
                if (!await AStoreExists(id))
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
            // _context.AStores.Add(aStore);
            //await _context.SaveChangesAsync();
            await _unitOfWork.AStores.Insert(aStore);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAStore", new { id = aStore.Id }, aStore);
        }

        // DELETE: api/AStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAStore(int id)
        {
            //var aStore = await _context.AStores.FindAsync(id);
            var aStore = await _unitOfWork.AStores.Get(q => q.Id == id);
            if (aStore == null)
            {
                return NotFound();
            }

            //_context.AStores.Remove(aStore);
            //await _context.SaveChangesAsync();
            await _unitOfWork.AStores.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool AStoreExists(int id)
        private async Task<bool> AStoreExists(int id)
        {
            //return _context.AStores.Any(e => e.Id == id);
            var aStore = await _unitOfWork.AStores.Get(q => q.Id == id);
            return aStore != null;
        }
    }
}

