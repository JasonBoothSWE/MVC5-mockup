using Microsoft.Extensions.Configuration.UserSecrets;

namespace MVC5_mockup.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
