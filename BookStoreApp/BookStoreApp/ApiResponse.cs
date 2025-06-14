using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class ApiResponse
    {
        [JsonPropertyName("$values")]
        public List<Book> Values { get; set; }
    }

}
