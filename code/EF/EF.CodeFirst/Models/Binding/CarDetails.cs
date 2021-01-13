using System;
using System.Collections.Generic;
using System.Text;

namespace EF.CodeFirst.Models.Binding
{
    public class CarDetails
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
