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
    public class CustomerDetailController : ControllerBase
    {
        private readonly AllClassContext _context;

        public CustomerDetailController(AllClassContext context)
        {
            _context = context;
        }

        // GET: api/CustomerDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDetails>>> GetcustomerDetails()
        {
            return await _context.customerDetails.ToListAsync();
        }

        // GET: api/CustomerDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetails>> GetCustomerDetails(int id)
        {
            var customerDetails = await _context.customerDetails.FindAsync(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return customerDetails;
        }

        // PUT: api/CustomerDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerDetails(int id, CustomerDetails customerDetails)
        {
            if (id != customerDetails.Customer_Id)
            {
                return BadRequest();
            }

            _context.Entry(customerDetails).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerDetailsExists(id))
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

        // POST: api/CustomerDetail
        [HttpPost]
        public async Task<ActionResult<CustomerDetails>> PostCustomerDetails(CustomerDetails customerDetails)
        {
            _context.customerDetails.Add(customerDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerDetails", new { id = customerDetails.Customer_Id }, customerDetails);
        }

        // DELETE: api/CustomerDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerDetails>> DeleteCustomerDetails(int id)
        {
            var customerDetails = await _context.customerDetails.FindAsync(id);
            if (customerDetails == null)
            {
                return NotFound();
            }

            _context.customerDetails.Remove(customerDetails);
            await _context.SaveChangesAsync();

            return customerDetails;
        }

        private bool CustomerDetailsExists(int id)
        {
            return _context.customerDetails.Any(e => e.Customer_Id == id);
        }
    }
}
