using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace FitnessLFG.Models
{
    public class Crud
    {
        [Key]
        public int CrudId { get; set; }

        [Display(Name = "Sport")]
        [Required(ErrorMessage = "Required to fill in.")]
        public CrudType Type { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string ActivityCategory { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string FullName { get; set; }

        [Display(Name = "Mobile No.")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string MobileNumber { get; set; }

        public DateTime Schedule { get; set; }

        [Display(Name = "Meeting Place")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string MeetingPlace { get; set; }

        [Display(Name = "Max No. of People")]
        [Required(ErrorMessage = "Required to fill in.")]
        public string MaxNumberPeople { get; set; }
    }

    public enum CrudType
    {
        Biking = 1,
        Jogging = 2,
        Zumba = 3
    }
}