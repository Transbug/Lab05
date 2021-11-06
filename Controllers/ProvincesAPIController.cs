using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab04.Data;
using Lab04.Models;
using Microsoft.AspNetCore.Cors;

namespace Lab04.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("APIPolicy")]
    [ApiController]
    public class ProvincesAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProvincesAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProvincesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Province>>> GetProvinces()
        {
            return await _context.Provinces
                        // .Include(p => p.Cities)
                         .ToListAsync();
        }

        // GET: api/ProvincesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Province>> GetProvince(string id)
        {
            var province = await _context.Provinces.FindAsync(id);

            if (province == null)
            {
                return NotFound();
            }

            return province;
        }

        // PUT: api/ProvincesAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvince(string id, Province province)
        {
            if (id != province.ProvinceCode)
            {
                return BadRequest();
            }

            _context.Entry(province).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinceExists(id))
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

        // POST: api/ProvincesAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Province>> PostProvince(Province province)
        {
            _context.Provinces.Add(province);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProvinceExists(province.ProvinceCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProvince", new { id = province.ProvinceCode }, province);
        }

        // DELETE: api/ProvincesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvince(string id)
        {
            var province = await _context.Provinces.FindAsync(id);
            if (province == null)
            {
                return NotFound();
            }

            _context.Provinces.Remove(province);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// customer API endpointer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/patients/3/medication
        //[HttpGet("{id:int}/")]
        //public async Task<IActionResult> GetCities(int id)
        //{
        //    var province = await _context.Provinces
        //      .Include(c => c.Cities)
        //      .FirstOrDefaultAsync(i => Int32.Parse(i.ProvinceCode) == id);

        //    if (province == null)
        //        return NotFound();

        //    return Ok(province.Cities);
        //}


        private bool ProvinceExists(string id)
        {
            return _context.Provinces.Any(e => e.ProvinceCode == id);
        }
    }
}
