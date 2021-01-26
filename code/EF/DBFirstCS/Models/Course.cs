using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirstCS.Models
{
    public partial class Course
    {
        public Course()
        {
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
