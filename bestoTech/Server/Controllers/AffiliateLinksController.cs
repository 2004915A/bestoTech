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
    public class AffiliateLinksController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public AffiliateLinksController(ApplicationDbContext context)
        public AffiliateLinksController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/AffiliateLinks
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<AffiliateLink>>> GetAffiliateLinks()
        public async Task<IActionResult> GetAffiliateLinks()
        {
            //return await _context.AffiliateLinks.ToListAsync();
            var affiliatelinks = await _unitOfWork.AffiliateLinks.GetAll();
            return Ok(affiliatelinks);
        }

        // GET: api/AffiliateLinks/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<AffiliateLink>> GetAffiliateLink(int id)
        public async Task<IActionResult> GetAffiliateLink(int id)
        {
            //var affiliatelink = await _context.AffiliateLinks.FindAsync(id);
            var affiliatelink = await _unitOfWork.AffiliateLinks.Get(q => q.Id == id);

            if (affiliatelink == null)
            {
                return NotFound();
            }

            //return affiliatelink;
            return Ok(affiliatelink);
        }

        // PUT: api/AffiliateLinks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAffiliateLink(int id, AffiliateLink affiliatelink)
        {
            if (id != affiliatelink.Id)
            {
                return BadRequest();
            }

            //_context.Entry(affiliatelink).State = EntityState.Modified;
            _unitOfWork.AffiliateLinks.Update(affiliatelink);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!AffiliateLinkExists(id))
                if (!await AffiliateLinkExists(id))
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

        // POST: api/AffiliateLinks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AffiliateLink>> PostAffiliateLink(AffiliateLink affiliatelink)
        {
            // _context.AffiliateLinks.Add(affiliatelink);
            //await _context.SaveChangesAsync();
            await _unitOfWork.AffiliateLinks.Insert(affiliatelink);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAffiliateLink", new { id = affiliatelink.Id }, affiliatelink);
        }

        // DELETE: api/AffiliateLinks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAffiliateLink(int id)
        {
            //var affiliatelink = await _context.AffiliateLinks.FindAsync(id);
            var affiliatelink = await _unitOfWork.AffiliateLinks.Get(q => q.Id == id);
            if (affiliatelink == null)
            {
                return NotFound();
            }

            //_context.AffiliateLinks.Remove(affiliatelink);
            //await _context.SaveChangesAsync();
            await _unitOfWork.AffiliateLinks.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool AffiliateLinkExists(int id)
        private async Task<bool> AffiliateLinkExists(int id)
        {
            //return _context.AffiliateLinks.Any(e => e.Id == id);
            var affiliatelink = await _unitOfWork.AffiliateLinks.Get(q => q.Id == id);
            return affiliatelink != null;
        }
    }
}

