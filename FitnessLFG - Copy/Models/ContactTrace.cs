using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace FitnessLFG.Models
{
    public class ContactTrace
    {
        [Key]
        public int TraceId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string FullName { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string ContactNum { get; set; }

        [Required(ErrorMessage = "Required to fill in.")]
        public string Email { get; set; }

        [Display(Name = "Vaccine Center")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string VaccineCenter { get; set; }

        [Display(Name = "How many vaccine shots have you taken?")]
        [Required(ErrorMessage = "Required to fill in.")]
        public AmountofDoses Doses { get; set; }

        [Display(Name = "Have you contacted anyone sick the past 2 weeks?")]
        [Required(ErrorMessage = "Required to fill in.")]
        public ContactAnySick SickContact { get; set; }

        [Display(Name = "Are you experiencing any symptoms of COVID-19?")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string Symptoms { get; set; }
    }

    public enum AmountofDoses
    {
        Zero = 1,
        One = 2,
        Two = 3
    }

    public enum ContactAnySick
    {
        Yes = 1,
        No = 2
    }
}
