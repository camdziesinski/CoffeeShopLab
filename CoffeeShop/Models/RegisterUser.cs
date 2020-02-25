using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be between 2 and 30 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Must be between 8 and 12 characters")]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$")]
        public string Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public bool Human { get; set; }

        
    }
}
