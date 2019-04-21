using System;

namespace Lab11.Models
{
    public class Course
    {
        public int CourseId {get; set;}
        public string Description {get; set;}
        public int ProfessorId {get; set;} // Foreign Key
        public Professor Professor {get; set;} // Navigation property. A course can only be taught by one professor.
    }
}