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
    public class AffiliateLinksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AffiliateLinksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AffiliateLinks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AffiliateLink>>> GetAffiliateLinks()
        {
            return await _context.AffiliateLinks.ToListAsync();
        }

        // GET: api/AffiliateLinks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AffiliateLink>> GetAffiliateLink(int id)
        {
            var affiliateLink = await _context.AffiliateLinks.FindAsync(id);

            if (affiliateLink == null)
            {
                return NotFound();
            }

            return affiliateLink;
        }

        // PUT: api/AffiliateLinks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAffiliateLink(int id, AffiliateLink affiliateLink)
        {
            if (id != affiliateLink.Id)
            {
                return BadRequest();
            }

            _context.Entry(affiliateLink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AffiliateLinkExists(id))
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
        public async Task<ActionResult<AffiliateLink>> PostAffiliateLink(AffiliateLink affiliateLink)
        {
            _context.AffiliateLinks.Add(affiliateLink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAffiliateLink", new { id = affiliateLink.Id }, affiliateLink);
        }

        // DELETE: api/AffiliateLinks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAffiliateLink(int id)
        {
            var affiliateLink = await _context.AffiliateLinks.FindAsync(id);
            if (affiliateLink == null)
            {
                return NotFound();
            }

            _context.AffiliateLinks.Remove(affiliateLink);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AffiliateLinkExists(int id)
        {
            return _context.AffiliateLinks.Any(e => e.Id == id);
        }
    }
}
