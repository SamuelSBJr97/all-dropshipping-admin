using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DropshippingAdmin.Infrastructure;
using InfrastructureService.Domain;
using Microsoft.AspNetCore.Authorization;

namespace DropshippingAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessagesStatusController : ControllerBase
    {
        private readonly DropshippingAdminContext _context;

        public MessagesStatusController(DropshippingAdminContext context)
        {
            _context = context;
        }

        // GET: api/MessagesStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessagesStatus>>> GetMessagesStatus()
        {
            return await _context.MessagesStatus.ToListAsync();
        }

        // GET: api/MessagesStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MessagesStatus>> GetMessagesStatus(Guid id)
        {
            var messagesStatus = await _context.MessagesStatus.FindAsync(id);

            if (messagesStatus == null)
            {
                return NotFound();
            }

            return messagesStatus;
        }

        // PUT: api/MessagesStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessagesStatus(Guid id, MessagesStatus messagesStatus)
        {
            if (id != messagesStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(messagesStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessagesStatusExists(id))
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

        // POST: api/MessagesStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MessagesStatus>> PostMessagesStatus(MessagesStatus messagesStatus)
        {
            _context.MessagesStatus.Add(messagesStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessagesStatus", new { id = messagesStatus.Id }, messagesStatus);
        }

        // DELETE: api/MessagesStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessagesStatus(Guid id)
        {
            var messagesStatus = await _context.MessagesStatus.FindAsync(id);
            if (messagesStatus == null)
            {
                return NotFound();
            }

            _context.MessagesStatus.Remove(messagesStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessagesStatusExists(Guid id)
        {
            return _context.MessagesStatus.Any(e => e.Id == id);
        }
    }
}
