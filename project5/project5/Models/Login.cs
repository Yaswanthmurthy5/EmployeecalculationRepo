using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Mvcproject.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Enter Username")]
        public String Username { get; set; }
        [Required(ErrorMessage ="Enter Password")]
        public string Password { get; set; }

    }
}