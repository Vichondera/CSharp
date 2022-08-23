using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;

namespace BookingApp.Models.Hotels
{
    public class Hotel : IHotel
    {
        public Hotel(string fullName, int category)
        {

        }

        public string FullName => throw new System.NotImplementedException();

        public int Category => throw new System.NotImplementedException();

        public double Turnover => throw new System.NotImplementedException();

        public IRepository<IRoom> Rooms { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IRepository<IBooking> Bookings { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
