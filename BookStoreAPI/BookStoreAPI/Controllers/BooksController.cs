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
    public class BooksController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public BooksController(BookStoreContext context)
        {
            _context = context;
        }
        [HttpPost("add")]
        public async Task<ActionResult<Book>> AddBook([FromBody] BookDTO bookDto)
        {
            // Check if the author exists
            var existingAuthor = await _context.Authors.FirstOrDefaultAsync(a => a.Name == bookDto.Author);

            // If the author doesn't exist, create a new one
            if (existingAuthor == null)
            {
                existingAuthor = new Author { Name = bookDto.Author };
                _context.Authors.Add(existingAuthor);
                await _context.SaveChangesAsync();
            }

            // Create a new book
            var newBook = new Book
            {
                Title = bookDto.Title,
                AuthorID = existingAuthor.ID,
                Price = bookDto.Price
            };

            // Add the book to the database
            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();

            // Return the created book
            return CreatedAtAction(nameof(GetBook), new { id = newBook.ID }, newBook);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookDTO updateBookDto)
        {
            // Find the book based on OldTitle and OldAuthor
            var book = await _context.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Title == updateBookDto.OldTitle && b.Author.Name == updateBookDto.OldAuthor);

            if (book == null)
            {
                return NotFound("The book with the specified title and author was not found.");
            }

            // Check if the new author exists
            var existingAuthor = await _context.Authors.FirstOrDefaultAsync(a => a.Name == updateBookDto.NewAuthor);

            // If the new author doesn't exist, create a new one
            if (existingAuthor == null)
            {
                existingAuthor = new Author { Name = updateBookDto.NewAuthor };
                _context.Authors.Add(existingAuthor);
                await _context.SaveChangesAsync();
            }

            // Update the book's details
            book.Title = updateBookDto.NewTitle;
            book.AuthorID = existingAuthor.ID;
            book.Price = updateBookDto.NewPrice;

            // Save changes to the database
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(book.ID))
                {
                    return NotFound("The book no longer exists.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        // DELETE: api/Books/delete
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteBookByTitleAndAuthor([FromBody] DeleteBookDTO deleteBookDTO)
        {
            // Find the book based on title and author
            var book = await _context.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Title == deleteBookDTO.Title && b.Author.Name == deleteBookDTO.Author);

            if (book == null)
            {
                return NotFound("The book with the specified title and author was not found.");
            }

            // Remove the book from the database
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }   

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks()
        {
            var books = await _context.Books
                .Select(b => new BookDTO
                {
                    Title = b.Title,
                    Author = b.Author.Name,
                    Price = b.Price
                })
                .ToListAsync();

            return Ok(books);
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.ID)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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

        // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.ID }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.ID == id);
        }
    }
}