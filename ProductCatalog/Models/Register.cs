using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductCatalog.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Your name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Your surname")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Your username")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Your email address")]
        [EmailAddress(ErrorMessage = "Make sure your e-mail address is correct.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Your password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Password repeat")]
        [Compare("Password", ErrorMessage = "Your passwords don't match.")]
        public string RePassword { get; set; }
    }
}