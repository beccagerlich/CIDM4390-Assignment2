using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
namespace Assignment2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "First NAme")]
        [Required]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LName { get; set; }
        [Required]
        public string Skills { get; set; }
    }
}