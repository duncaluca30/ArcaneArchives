namespace BookStoreAPI
{
    public class UpdateBookDTO
    {
        public string OldTitle { get; set; }
        public string OldAuthor { get; set; }
        public string NewTitle { get; set; }
        public string NewAuthor { get; set; }
        public decimal NewPrice { get; set; }
    }
}