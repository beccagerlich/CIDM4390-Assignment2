using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Skills { get; set; }
    }
}