namespace BookingApp.Models.Bookings
{
    using BookingApp.Models.Bookings.Contracts;
    using BookingApp.Models.Rooms.Contracts;
    
    public class Booking : IBooking
    {
        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {

        }

        public IRoom Room => throw new System.NotImplementedException();

        public int ResidenceDuration => throw new System.NotImplementedException();

        public int AdultsCount => throw new System.NotImplementedException();

        public int ChildrenCount => throw new System.NotImplementedException();

        public int BookingNumber => throw new System.NotImplementedException();

        public string BookingSummary()
        {
            throw new System.NotImplementedException();
        }
    }
}
