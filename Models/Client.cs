using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
namespace Assignment2.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Display(Name = "Client Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CName { get; set; }
        [Display(Name = "Project Due Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DueDate { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }
    }
}