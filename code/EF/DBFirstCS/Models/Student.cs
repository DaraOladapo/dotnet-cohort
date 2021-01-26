using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirstCS.Models
{
    public partial class Student
    {
        public Student()
        {
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
