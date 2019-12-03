using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Car_sales.Models;

namespace Car_sales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefModelTypesController : ControllerBase
    {
        private readonly CarSalesContext _context;

        public RefModelTypesController(CarSalesContext context)
        {
            _context = context;
        }

        // GET: api/RefModelTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefModelTypes>>> GetRefModelTypes()
        {
            return await _context.RefModelTypes.ToListAsync();
        }

        // GET: api/RefModelTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RefModelTypes>> GetRefModelTypes(long id)
        {
            var refModelTypes = await _context.RefModelTypes.FindAsync(id);

            if (refModelTypes == null)
            {
                return NotFound();
            }

            return refModelTypes;
        }

        // PUT: api/RefModelTypes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefModelTypes(long id, RefModelTypes refModelTypes)
        {
            if (id != refModelTypes.ModelTypeCode)
            {
                return BadRequest();
            }

            _context.Entry(refModelTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefModelTypesExists(id))
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

        // POST: api/RefModelTypes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RefModelTypes>> PostRefModelTypes(RefModelTypes refModelTypes)
        {
            _context.RefModelTypes.Add(refModelTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefModelTypes", new { id = refModelTypes.ModelTypeCode }, refModelTypes);
        }

        // DELETE: api/RefModelTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RefModelTypes>> DeleteRefModelTypes(long id)
        {
            var refModelTypes = await _context.RefModelTypes.FindAsync(id);
            if (refModelTypes == null)
            {
                return NotFound();
            }

            _context.RefModelTypes.Remove(refModelTypes);
            await _context.SaveChangesAsync();

            return refModelTypes;
        }

        private bool RefModelTypesExists(long id)
        {
            return _context.RefModelTypes.Any(e => e.ModelTypeCode == id);
        }
    }
}
