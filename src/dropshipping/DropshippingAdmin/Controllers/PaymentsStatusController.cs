using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DropshippingAdmin.Infrastructure;
using InfrastructureService.Domain;

namespace DropshippingAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsStatusController : ControllerBase
    {
        private readonly DropshippingAdminContext _context;

        public PaymentsStatusController(DropshippingAdminContext context)
        {
            _context = context;
        }

        // GET: api/PaymentsStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentsStatus>>> GetPaymentsStatus()
        {
            return await _context.PaymentsStatus.ToListAsync();
        }

        // GET: api/PaymentsStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentsStatus>> GetPaymentsStatus(Guid id)
        {
            var paymentsStatus = await _context.PaymentsStatus.FindAsync(id);

            if (paymentsStatus == null)
            {
                return NotFound();
            }

            return paymentsStatus;
        }

        // PUT: api/PaymentsStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentsStatus(Guid id, PaymentsStatus paymentsStatus)
        {
            if (id != paymentsStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(paymentsStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentsStatusExists(id))
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

        // POST: api/PaymentsStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentsStatus>> PostPaymentsStatus(PaymentsStatus paymentsStatus)
        {
            _context.PaymentsStatus.Add(paymentsStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentsStatus", new { id = paymentsStatus.Id }, paymentsStatus);
        }

        // DELETE: api/PaymentsStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentsStatus(Guid id)
        {
            var paymentsStatus = await _context.PaymentsStatus.FindAsync(id);
            if (paymentsStatus == null)
            {
                return NotFound();
            }

            _context.PaymentsStatus.Remove(paymentsStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentsStatusExists(Guid id)
        {
            return _context.PaymentsStatus.Any(e => e.Id == id);
        }
    }
}
