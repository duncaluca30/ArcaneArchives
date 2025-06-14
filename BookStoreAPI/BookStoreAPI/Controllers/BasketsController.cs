using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Data;
using BookStoreAPI.Models;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public BasketsController(BookStoreContext context)
        {
            _context = context;
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Basket>>> GetUserBasket(int userId)
        {
            return await _context.Basket
                .Where(b => b.UserID == userId)
                .Include(b => b.Book)
                .ToListAsync();
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToBasket(Basket basketItem)

        {
            var existingItem = await _context.Basket.FirstOrDefaultAsync(b => b.UserID == basketItem.UserID && b.BookID == basketItem.BookID);

            if (existingItem != null)
            {
                // If book is already in basket, increase quantity instead of adding a new row
                existingItem.Quantity += basketItem.Quantity;
                await _context.SaveChangesAsync();
                return Ok(existingItem);
            }

            // Otherwise, add as a new basket entry
            _context.Basket.Add(basketItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserBasket), new { userId = basketItem.UserID }, basketItem);
        }

        [HttpDelete("{basketId}")]
        public async Task<IActionResult> RemoveFromBasket(int basketId)
        {
            var item = await _context.Basket.FindAsync(basketId);

            if (item == null) return NotFound();

            // If quantity is more than 1, decrease it instead of deleting
            if (item.Quantity > 1)
            {
                item.Quantity -= 1;
                await _context.SaveChangesAsync();
                return Ok(item);
            }

            // If quantity reaches 0, remove the item from basket
            _context.Basket.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Baskets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Basket>>> GetBasket()
        {
            return await _context.Basket.ToListAsync();
        }

        // GET: api/Baskets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Basket>> GetBasket(int id)
        {
            var basket = await _context.Basket.FindAsync(id);

            if (basket == null)
            {
                return NotFound();
            }

            return basket;
        }

        // PUT: api/Baskets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasket(int id, Basket basket)
        {
            if (id != basket.ID)
            {
                return BadRequest();
            }

            _context.Entry(basket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasketExists(id))
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

        // POST: api/Baskets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Basket>> PostBasket(Basket basket)
        {
            _context.Basket.Add(basket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBasket", new { id = basket.ID }, basket);
        }

        // DELETE: api/Baskets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasket(int id)
        {
            var basket = await _context.Basket.FindAsync(id);
            if (basket == null)
            {
                return NotFound();
            }

            _context.Basket.Remove(basket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BasketExists(int id)
        {
            return _context.Basket.Any(e => e.ID == id);
        }
    }
}
