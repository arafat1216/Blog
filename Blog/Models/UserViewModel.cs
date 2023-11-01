using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class UserViewModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
