using Microsoft.Extensions.Hosting;

namespace OnlineShopping.Models
{
    public class CustomProduct
    {
        public string title { get; set; }
        public string image { get; set; }
        public string cost { get; set; }
        public string uid { get; set; }
        public string cid { get; set; }
    }
}
