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
    public class ALinksController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public ALinksController(ApplicationDbContext context)
        public ALinksController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/ALinks
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<ALink>>> GetALinks()
        public async Task<IActionResult> GetALinks()
        {
            //return await _context.ALinks.ToListAsync();
            var affiliatelinks = await _unitOfWork.ALinks.GetAll();
            return Ok(affiliatelinks);
        }

        // GET: api/ALinks/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<ALink>> GetALink(int id)
        public async Task<IActionResult> GetALink(int id)
        {
            //var affiliatelink = await _context.ALinks.FindAsync(id);
            var affiliatelink = await _unitOfWork.ALinks.Get(q => q.Id == id);

            if (affiliatelink == null)
            {
                return NotFound();
            }

            //return affiliatelink;
            return Ok(affiliatelink);
        }

        // PUT: api/ALinks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutALink(int id, ALink affiliatelink)
        {
            if (id != affiliatelink.Id)
            {
                return BadRequest();
            }

            //_context.Entry(affiliatelink).State = EntityState.Modified;
            _unitOfWork.ALinks.Update(affiliatelink);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ALinkExists(id))
                if (!await ALinkExists(id))
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

        // POST: api/ALinks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ALink>> PostALink(ALink affiliatelink)
        {
            // _context.ALinks.Add(affiliatelink);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ALinks.Insert(affiliatelink);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetALink", new { id = affiliatelink.Id }, affiliatelink);
        }

        // DELETE: api/ALinks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteALink(int id)
        {
            //var affiliatelink = await _context.ALinks.FindAsync(id);
            var affiliatelink = await _unitOfWork.ALinks.Get(q => q.Id == id);
            if (affiliatelink == null)
            {
                return NotFound();
            }

            //_context.ALinks.Remove(affiliatelink);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ALinks.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ALinkExists(int id)
        private async Task<bool> ALinkExists(int id)
        {
            //return _context.ALinks.Any(e => e.Id == id);
            var affiliatelink = await _unitOfWork.ALinks.Get(q => q.Id == id);
            return affiliatelink != null;
        }
    }
}

