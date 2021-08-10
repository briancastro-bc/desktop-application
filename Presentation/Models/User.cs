using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class User
    {
        public string Id { get; set; }
        public string IdType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Rh { get; set; }
        public string Role { get; set; }
        public static readonly List<User> Storage = new()
        {
            new User() { Id = "1098306124", IdType = "TI", Username = "Yito", Password = "12345", Name = "Brian", LastName = "Castro", Gender = "M", Rh = "B+", Role = "Admin" }
        };
    }
}
