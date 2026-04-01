using System;

namespace Interface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public CarRental(DateTime start, DateTime finish)
        {
            Start = start;
            Finish = finish;
        }

    }
}
