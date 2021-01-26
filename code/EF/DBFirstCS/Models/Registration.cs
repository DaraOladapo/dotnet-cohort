using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirstCS.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? StudentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
