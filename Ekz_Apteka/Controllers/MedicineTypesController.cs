using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EKZ.Models;
using Ekz_Apteka.Models;

namespace Ekz_Apteka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineTypesController : ControllerBase
    {
        private readonly EkzDbContext _context;

        public MedicineTypesController(EkzDbContext context)
        {
            _context = context;
        }

        // GET: api/MedicineTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicineType>>> GetMedicineTypes()
        {
            return await _context.MedicineTypes.ToListAsync();
        }

        // GET: api/MedicineTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicineType>> GetMedicineType(int id)
        {
            var medicineType = await _context.MedicineTypes.FindAsync(id);

            if (medicineType == null)
            {
                return NotFound();
            }

            return medicineType;
        }

        // PUT: api/MedicineTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicineType(int id, MedicineType medicineType)
        {
            if (id != medicineType.MedicineTypeId)
            {
                return BadRequest();
            }

            _context.Entry(medicineType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicineTypeExists(id))
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

        // POST: api/MedicineTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MedicineType>> PostMedicineType(MedicineType medicineType)
        {
            _context.MedicineTypes.Add(medicineType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicineType", new { id = medicineType.MedicineTypeId }, medicineType);
        }

        // DELETE: api/MedicineTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicineType(int id)
        {
            var medicineType = await _context.MedicineTypes.FindAsync(id);
            if (medicineType == null)
            {
                return NotFound();
            }

            _context.MedicineTypes.Remove(medicineType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicineTypeExists(int id)
        {
            return _context.MedicineTypes.Any(e => e.MedicineTypeId == id);
        }
    }
}
