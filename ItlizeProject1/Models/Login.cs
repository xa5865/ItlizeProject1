using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItlizeProject1.Models
{
    public class Login
    {
        [Required(ErrorMessage ="The username should not be empty")]
        [RegularExpression("^[a-zA-Z0-9_-]{0,10}$",ErrorMessage = "The username only contains numbers,letters and _")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password should not be empty")]
        [RegularExpression("^[a-zA-Z0-9]{0,10}$",ErrorMessage = "The password only contains numbers,letters")]
        public string Password { get; set; }

        public string Message { get; set; }

    }
}