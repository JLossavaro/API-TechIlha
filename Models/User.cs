using System.ComponentModel.DataAnnotations;

namespace ApiTechIlha.Models
{
    public class User
    {
        public User() { }
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }

    }
}
