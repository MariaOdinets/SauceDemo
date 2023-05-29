using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Models
{
    public record User
    {
        public string? UserType { get; set; }
        public string? Username { get; set; } 
        public string? Password { get; set; } 
    }
}