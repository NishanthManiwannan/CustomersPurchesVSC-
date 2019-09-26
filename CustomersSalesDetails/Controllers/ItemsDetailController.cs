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
    public class ItemsDetailController : ControllerBase
    {
        private readonly AllClassContext _context;

        public ItemsDetailController(AllClassContext context)
        {
            _context = context;
        }

        // GET: api/ItemsDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemsDetails>>> GetitemsDetails()
        {
            return await _context.itemsDetails.ToListAsync();
        }

        // GET: api/ItemsDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemsDetails>> GetItemsDetails(int id)
        {
            var itemsDetails = await _context.itemsDetails.FindAsync(id);

            if (itemsDetails == null)
            {
                return NotFound();
            }

            return itemsDetails;
        }

        // PUT: api/ItemsDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemsDetails(int id, ItemsDetails itemsDetails)
        {
            if (id != itemsDetails.Item_Id)
            {
                return BadRequest();
            }

            _context.Entry(itemsDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsDetailsExists(id))
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

        // POST: api/ItemsDetail
        [HttpPost]
        public async Task<ActionResult<ItemsDetails>> PostItemsDetails(ItemsDetails itemsDetails)
        {
            _context.itemsDetails.Add(itemsDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemsDetails", new { id = itemsDetails.Item_Id }, itemsDetails);
        }

        // DELETE: api/ItemsDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemsDetails>> DeleteItemsDetails(int id)
        {
            var itemsDetails = await _context.itemsDetails.FindAsync(id);
            if (itemsDetails == null)
            {
                return NotFound();
            }

            _context.itemsDetails.Remove(itemsDetails);
            await _context.SaveChangesAsync();

            return itemsDetails;
        }

        private bool ItemsDetailsExists(int id)
        {
            return _context.itemsDetails.Any(e => e.Item_Id == id);
        }
    }
}
