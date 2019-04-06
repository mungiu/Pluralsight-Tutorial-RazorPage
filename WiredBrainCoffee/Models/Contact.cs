using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        [Required, Phone, MinLength(6)]
        public string PhoneNumber { get; set; }
        [Required, EmailAddress, MinLength(5)]
        public string Email { get; set; }
        [Required, MinLength(25)]
        public string Message { get; set; }
    }
}
