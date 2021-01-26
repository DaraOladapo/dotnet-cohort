using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Models.Entity
{
    public class Registration
    {
        public int Id { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
