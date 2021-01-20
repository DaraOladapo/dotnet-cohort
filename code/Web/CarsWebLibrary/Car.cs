using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarsWebLibrary
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        [MaxLength(4), MinLength(4)]
        public int Year { get; set; }
    }
}
