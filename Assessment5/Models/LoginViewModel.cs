using System.ComponentModel;

namespace Assessment5.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }

        [DisplayName("User Name")]
        public string Name { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
