using System.ComponentModel.DataAnnotations;

namespace MVC_Guerrero.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public DateTime Date { get; set; }


        // Foreing Key para STUDENT

        public int StudentID { get; set; }
        public Student Student { get; set; }

        // Foreing Key para COURSE
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
