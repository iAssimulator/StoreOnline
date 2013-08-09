using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(255, ErrorMessage = "Must be between 4 and 255 characters", MinimumLength = 4)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
