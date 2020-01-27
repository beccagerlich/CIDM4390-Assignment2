using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string CName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}