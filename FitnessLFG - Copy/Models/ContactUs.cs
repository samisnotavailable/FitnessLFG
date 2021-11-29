using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;

namespace FitnessLFG.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field.")]
        public string Sender { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid format.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Required field.")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Required field.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}


