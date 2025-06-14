namespace BookStoreAPI.Data
{
    using BookStoreAPI.Models;
    using Microsoft.EntityFrameworkCore;

    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }
        public BookStoreContext() { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Basket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    }
}