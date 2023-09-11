using System.Net;

namespace OnlineShopping.Models
{
    public class Order
    {
        public string order_id { get; set; }
        public string name { get; set; }
        public string address {get;set;}
        public string city    {get;set;}
        public string state   {get;set;}
        public string zip_code{get;set;}
        public string contact {get;set;}
        public ICollection<Cart> Carts { get;set;}

    }
}
