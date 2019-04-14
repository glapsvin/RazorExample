using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorExample.Models
{
    public class Person
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        [EmailAddress]
        [Remote("VerifyEmail", "Person")]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        
        public Address HomeAddress { get; set; }
        
    }
}
