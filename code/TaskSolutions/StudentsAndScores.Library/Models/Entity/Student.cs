using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndScores.Library.Models.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        //public List<Registration> Registrations { get; set; }
    }
}
