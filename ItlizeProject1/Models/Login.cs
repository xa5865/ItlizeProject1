using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItlizeProject1.Models
{
    public class Login
    {
        [Required(ErrorMessage ="The user id should not be empty")]
        [RegularExpression("^[a-zA-Z0-9_-_@]{1,20}$",ErrorMessage = "The user id or email should only contain 1 to 20 numbers ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password should not be empty")]
        [RegularExpression("^[a-zA-Z0-9]{1,10}$",ErrorMessage = "The password should only contain 1 to 10 numbers or letters")]
        public string Password { get; set; }

        public string Message { get; set; }

    }
}