using BookingApp.Models.Bookings.Contracts;
using BookingApp.Repositories.Contracts;
using System.Collections.Generic;

namespace BookingApp.Repositories
{
    public class BookingRepository : IRepository<IBooking>
    {
        public BookingRepository()
        {

        }

        public void AddNew(IBooking model)
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyCollection<IBooking> All()
        {
            throw new System.NotImplementedException();
        }

        public IBooking Select(string criteria)
        {
            throw new System.NotImplementedException();
        }
    }
}
