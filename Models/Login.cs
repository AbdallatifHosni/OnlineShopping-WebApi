using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace OnlineShopping.Models
{
    public class Login
    {
       public string  username { get; set; }    
       public string email { get; set; }
       public string contact { get; set; }
       public string role { get; set; }
    }
}
