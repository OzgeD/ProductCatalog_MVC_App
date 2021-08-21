using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductCatalog.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Your username")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Your password")]
        public string Password { get; set; }


        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}