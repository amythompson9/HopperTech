using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HopperTech.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string HomeAddress { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Student_Course> Students_Courses { get; set; }
    }
}