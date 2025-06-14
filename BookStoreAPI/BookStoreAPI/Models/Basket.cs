namespace BookStoreAPI.Models
{
    public class Basket
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; } = 1;

        public Book Book { get; set; }
    }
}
