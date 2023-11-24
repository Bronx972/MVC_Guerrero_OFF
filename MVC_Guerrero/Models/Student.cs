using System.ComponentModel.DataAnnotations;

namespace MVC_Guerrero.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        //Llave Foranea

        public int GradeID { get; set; }
        public Grade? Grade { get; set; }
    }
}
