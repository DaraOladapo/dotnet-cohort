using System;

namespace CarConsole
{
    public interface ICar
    {
        public Guid ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
