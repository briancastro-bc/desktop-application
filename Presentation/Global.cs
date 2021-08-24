using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;

namespace Presentation
{
    public class Global
    {
        public static readonly User Data = new();
        public static List<Carnet> CarnetsStorage = new();
        public static readonly List<User> Storage = new()
        {
            new User() { Id = "1098306124", IdType = "TI", Username = "Yito", Password = "12345", Name = "Brian", LastName = "Castro", Gender = "M", Rh = "B+", Role = "Admin" },
            new User() { Id = "1092454221", IdType = "TI", Username = "ElSanti", Password = "12345", Name = "Santiago", LastName = "Castro", Gender = "M", Rh = "B+", Role = "Admin" }
        };
    }
}
