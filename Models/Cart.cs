namespace OnlineShopping.Models
{
    public class Cart
    {
        public string Custom { get; set; }
        public int   Size { get; set; }
        public int   Quantity { get; set; }

        public int  product_id { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
