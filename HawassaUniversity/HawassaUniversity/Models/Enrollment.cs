using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HawassaUniversity.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        //Foreign Key to Course Entity
        public int CourseID { get; set; }
        //Forign key to Student Entity
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}