using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class Book
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }


        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }

}
