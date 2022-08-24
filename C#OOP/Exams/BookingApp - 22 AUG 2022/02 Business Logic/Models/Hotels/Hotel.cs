namespace BookingApp.Models.Hotels
{
    using System;

    using BookingApp.Repositories;
    using BookingApp.Repositories.Contracts;

    using BookingApp.Models.Bookings.Contracts;
    using BookingApp.Models.Hotels.Contacts;
    using BookingApp.Models.Rooms.Contracts;
    using System.Linq;

    public class Hotel : IHotel
    {
        private string fullName;
        private int category;

        public Hotel(string fullName, int category)
        {
            this.FullName = fullName;
            this.Category = category;
            this.Rooms = new RoomRepository();
            this.Bookings = new BookingRepository(); 
        }

        public string FullName
        {
            get => fullName;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hotel name cannot be null or empty!");
                }
                fullName = value;
            }
        }

        public int Category
        {
            get => category;
            protected set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException("Category should be between 1 and 5 stars!");
                }
                category = value;
            }
        }

        public double Turnover
            => Math.Round(Bookings.All().Sum(x => x.ResidenceDuration * x.Room.PricePerNight), 2);

        public IRepository<IRoom> Rooms { get; set; }

        public IRepository<IBooking> Bookings { get; set; }
    }
}
