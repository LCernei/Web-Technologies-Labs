using System;
using System.ComponentModel.DataAnnotations;

namespace LCourses.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
		[Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}