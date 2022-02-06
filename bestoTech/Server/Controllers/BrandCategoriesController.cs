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
    public class BrandCategoriesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public BrandCategoriesController(ApplicationDbContext context)
        public BrandCategoriesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/BrandCategories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<BrandCategory>>> GetBrandCategories()
        public async Task<IActionResult> GetBrandCategories()
        {
            //return await _context.BrandCategories.ToListAsync();
            var brandcategorys = await _unitOfWork.BrandCategories.GetAll();
            return Ok(brandcategorys);
        }

        // GET: api/BrandCategories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<BrandCategory>> GetBrand(int id)
        public async Task<IActionResult> GetBrand(int id)
        {
            //var brandcategory = await _context.BrandCategories.FindAsync(id);
            var brandcategory = await _unitOfWork.BrandCategories.Get(q => q.Id == id);

            if (brandcategory == null)
            {
                return NotFound();
            }

            //return brandcategory;
            return Ok(brandcategory);
        }

        // PUT: api/BrandCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, BrandCategory brandcategory)
        {
            if (id != brandcategory.Id)
            {
                return BadRequest();
            }

            //_context.Entry(brandcategory).State = EntityState.Modified;
            _unitOfWork.BrandCategories.Update(brandcategory);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BrandExists(id))
                if (!await BrandExists(id))
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

        // POST: api/BrandCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BrandCategory>> PostBrand(BrandCategory brandcategory)
        {
            // _context.BrandCategories.Add(brandcategory);
            //await _context.SaveChangesAsync();
            await _unitOfWork.BrandCategories.Insert(brandcategory);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBrand", new { id = brandcategory.Id }, brandcategory);
        }

        // DELETE: api/BrandCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            //var brandcategory = await _context.BrandCategories.FindAsync(id);
            var brandcategory = await _unitOfWork.BrandCategories.Get(q => q.Id == id);
            if (brandcategory == null)
            {
                return NotFound();
            }

            //_context.BrandCategories.Remove(brandcategory);
            //await _context.SaveChangesAsync();
            await _unitOfWork.BrandCategories.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool BrandExists(int id)
        private async Task<bool> BrandExists(int id)
        {
            //return _context.BrandCategories.Any(e => e.Id == id);
            var brandcategory = await _unitOfWork.BrandCategories.Get(q => q.Id == id);
            return brandcategory != null;
        }
    }
}
