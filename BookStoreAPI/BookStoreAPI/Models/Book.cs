namespace BookStoreAPI.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public decimal Price { get; set; }

        public Author Author { get; set; } // This remains as it represents the relationship with the Author entity.
    }
}