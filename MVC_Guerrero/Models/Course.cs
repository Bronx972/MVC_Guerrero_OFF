using System.ComponentModel.DataAnnotations;

namespace MVC_Guerrero.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

    }
}
