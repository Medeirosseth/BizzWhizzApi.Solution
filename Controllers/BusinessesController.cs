using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BizzWhizzApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BizzWhizzApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BusinessesController : ControllerBase
    {
        private readonly BizzWhizzApiContext _db;

        public BusinessesController(BizzWhizzApiContext db)
        {
            _db = db; 
        }

        private bool BusinessExists(int id) => _db.businesses.Any( b => b.BusinessId == id);

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> GetActionResultAsync()
        => await _db.businesses.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Business>> GetBusiness(int id)
        {
            var business = await _db.businesses.FindAsync(id);
            if ( business == null) return NotFound();
            return business;
        }

        [HttpPost]
        public async Task<ActionResult<Business>> Post(Business bizz)
        {
            _db.businesses.Add(bizz);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBusiness), new {id = bizz.BusinessId }, bizz);
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put(int id, Business bizz)
        {
            if (id !=bizz.BusinessId) return BadRequest();

            _db.Entry(bizz).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

    }

}
