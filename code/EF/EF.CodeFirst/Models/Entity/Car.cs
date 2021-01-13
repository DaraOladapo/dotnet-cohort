using System;
using System.Collections.Generic;
using System.Text;

namespace EF.CodeFirst.Models.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
