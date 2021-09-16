using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace orphanage_api.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "this field is required")]
        [DisplayName("registraion number")]
        public string oRegistrationNum { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "this field is required")]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}