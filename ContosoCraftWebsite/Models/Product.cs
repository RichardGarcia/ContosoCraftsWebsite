using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCraftWebsite.Models
{
    public class Product
    {
        [JsonPropertyName("img")]
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }


}