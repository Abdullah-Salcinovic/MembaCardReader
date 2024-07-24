using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data.Models;

namespace MakerspaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RFIDScansController : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public RFIDScansController(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rfidscan>>> GetRFIDScans()
        {
            return await _context.Rfidscans.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rfidscan>> GetRFIDScan(int id)
        {
            var rfidScan = await _context.Rfidscans.FindAsync(id);

            if (rfidScan == null)
            {
                return NotFound();
            }

            return rfidScan;
        }

        [HttpPost]
        public async Task<ActionResult<Rfidscan>> PostRFIDScan(Rfidscan rfidScan)
        {
            _context.Rfidscans.Add(rfidScan);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRFIDScan), new { id = rfidScan.ScanId }, rfidScan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRFIDScan(int id, Rfidscan rfidScan)
        {
            if (id != rfidScan.ScanId)
            {
                return BadRequest();
            }

            _context.Entry(rfidScan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RFIDScanExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRFIDScan(int id)
        {
            var rfidScan = await _context.Rfidscans.FindAsync(id);
            if (rfidScan == null)
            {
                return NotFound();
            }

            _context.Rfidscans.Remove(rfidScan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RFIDScanExists(int id)
        {
            return _context.Rfidscans.Any(e => e.ScanId == id);
        }
    }
}
