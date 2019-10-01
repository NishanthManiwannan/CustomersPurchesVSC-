using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomersSalesDetails.Models;

namespace CustomersSalesDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicTwoController : ControllerBase
    {
        private readonly AllClassContext _context;

        public InvoicTwoController(AllClassContext context)
        {
            _context = context;
        }

        // GET: api/InvoicTwo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoicTwo>>> GetinvoicTwos()
        {
            return await _context.invoicTwos.ToListAsync();
        }

        // GET: api/InvoicTwo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoicTwo>> GetInvoicTwo(int id)
        {
            var invoicTwo = await _context.invoicTwos.FindAsync(id);

            if (invoicTwo == null)
            {
                return NotFound();
            }

            return invoicTwo;
        }

        // PUT: api/InvoicTwo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoicTwo(int id, InvoicTwo invoicTwo)
        {
            if (id != invoicTwo.Invoice_Id)
            {
                return BadRequest();
            }

            _context.Entry(invoicTwo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoicTwoExists(id))
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

        // POST: api/InvoicTwo
        [HttpPost]
        public async Task<ActionResult<InvoicTwo>> PostInvoicTwo(InvoicTwo invoicTwo)
        {
            _context.invoicTwos.Add(invoicTwo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoicTwo", new { id = invoicTwo.Invoice_Id }, invoicTwo);
        }

        // DELETE: api/InvoicTwo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoicTwo>> DeleteInvoicTwo(int id)
        {
            var invoicTwo = await _context.invoicTwos.FindAsync(id);
            if (invoicTwo == null)
            {
                return NotFound();
            }

            _context.invoicTwos.Remove(invoicTwo);
            await _context.SaveChangesAsync();

            return invoicTwo;
        }

        private bool InvoicTwoExists(int id)
        {
            return _context.invoicTwos.Any(e => e.Invoice_Id == id);
        }
    }
}
