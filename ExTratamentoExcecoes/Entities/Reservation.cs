using System;
using ExTratamentoExcecoes.Entities.Exceptions;

namespace ExTratamentoExcecoes.Entities
{
    internal class Reservation
    {
        int RoomNumber { get; set; }
        DateTime CheckIn { get; set; }
        DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin , DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
