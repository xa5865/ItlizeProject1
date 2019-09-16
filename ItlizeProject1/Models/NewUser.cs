using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItlizeProject1.Models
{
    public class NewUser
    {
        [Required(ErrorMessage = "The username should not be empty")]
        [RegularExpression("^[a-zA-Z0-9_-]{0,10}$",ErrorMessage = "The username only contains numbers,letters and _")]
        public string Username2 { get; set; }

        [Required(ErrorMessage = "The password should not be empty")]
        [RegularExpression("^[a-zA-Z0-9]{0,10}$", ErrorMessage = "The username only contains numbers,letters")]
        public string Password2 { get; set; }

        [Required(ErrorMessage = "The password should not be empty")]
        [RegularExpression("^[a-zA-Z0-9]{0,10}$", ErrorMessage = "The password only contains numbers,letters")]
        [Compare("Password2",ErrorMessage ="The password should be the same")]
        public string Password3 { get; set; }

        [Required(ErrorMessage = "The email address should not be empty")]
        [RegularExpression("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+[.]+[a-zA-Z0-9_-]+$", ErrorMessage = "The email is not valid")]
        public string Email1 { get; set; }

        [Required(ErrorMessage = "The lastname should not be empty")]
        [RegularExpression("^[a-zA-Z]{0,10}$", ErrorMessage = "The name only contains letters")]
        public string Name1 { get; set; }

        [Required(ErrorMessage = "The firstname should not be empty")]
        [RegularExpression("^[a-zA-Z]{0,10}$", ErrorMessage = "The name only contains letters")]
        public string Name2 { get; set; }

        [Required(ErrorMessage = "The phone should not be empty")]
        [Phone(ErrorMessage = "The phone is not valid")]
        public string Phone1 { get; set; }

        public string Message { get; set; }
    }
}