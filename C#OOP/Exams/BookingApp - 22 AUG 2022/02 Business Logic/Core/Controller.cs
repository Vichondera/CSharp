namespace BookingApp.Core
{
    using System;
    using System.Linq;
    using System.Text;
    
    using BookingApp.Core.Contracts;
    using BookingApp.Models.Bookings.Contracts;
    using BookingApp.Models.Hotels;
    using BookingApp.Models.Hotels.Contacts;
    using BookingApp.Models.Rooms;
    using BookingApp.Models.Rooms.Contracts;
    using BookingApp.Repositories;
    using BookingApp.Repositories.Contracts;

    public class Controller : IController
    {
        private IRepository<IHotel> hotelRepo = new HotelRepository();

        public Controller()
        {

        }

        public string AddHotel(string hotelName, int category)
        {
            IHotel hotel = hotelRepo.Select(hotelName);
            
            if (hotel != null)
            {
                return $"Hotel {hotelName} is already registered in our platform.";
            }

            hotel = new Hotel(hotelName, category);
            this.hotelRepo.AddNew(hotel);

            return $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            IHotel hotel;
            IRoom room;
            int count = adults + children;

            foreach (var h in this.hotelRepo.All()
                .OrderBy(x=>x.FullName))
            {
               
                foreach (var r in h.Rooms.All()
                    .Where(x=>x.PricePerNight > 0)
                    .OrderBy(c=>c.BedCapacity))
                {
                    if(r.BedCapacity >= count)
                    {
                        hotel = h;
                        room = r;
                    }
                } // Foreach rooms
            } // foreach hotels

         
            // If none of the available hotels corresponds to the given category,
            // return $"{category} star hotel is not available in our platform.";

            // If none of the rooms can fit the requested guests,
            // return "We cannot offer appropriate room for your request.";

            // If the booking is successful, the method
            // return $"Booking number {bookingNumber} for {hotelName} hotel is successful!";

            // Also for successful booking you should add the new Booking in the BookingRepository of the selected hotel.
            // Every new Booking should have booking number equal to the total number of the already added bookings to the selected hotel increased by one: 
            // bookingNumber = totalBookingAppBookingsCount + 1;

            throw new System.NotImplementedException();
        }

        public string HotelReport(string hotelName)
        {
            IHotel hotel = this.hotelRepo.Select(hotelName);
            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
 
                var sb = new StringBuilder();

                sb.AppendLine($"Hotel name: {hotelName}");
                sb.AppendLine($"--{hotel.Category} star hotel");
                sb.AppendLine($"--Turnover: {hotel.Turnover:F2} $");
                sb.AppendLine($"--Bookings:");

            var a = hotel.Bookings.All().ToList();
            if(a.Count > 0)
            {
                foreach (var item in hotel.Bookings.All())
                {
                    sb.AppendLine(item.BookingSummary());
                }
            }
            else
            {
                sb.AppendLine("none");
            }

            return sb.ToString().TrimEnd();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            IHotel hotel = hotelRepo.Select(hotelName);

            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            
            if (roomTypeName != nameof(Apartment) &&
                roomTypeName != nameof(Studio) &&
                roomTypeName != nameof(DoubleBed))
            {
                 throw new ArgumentException($"Incorrect room type!"); 
            }

            IRoom room = hotel.Rooms.Select(roomTypeName);
            if (room == null)
            {
                return $"Room type is not created yet!";
            }

            if (room.PricePerNight > 0)
            {
                throw new InvalidOperationException("Price is already set!");
            }
            room.SetPrice(price);
            
            return $"Price of {roomTypeName} room type in {hotelName} hotel is set!";
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            IHotel hotel;

            if (hotelRepo.Select(hotelName) == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            hotel = hotelRepo.Select(hotelName);
            if (hotel.Rooms.Select(roomTypeName) != null)
            {
                return "Room type is already created!";
            }

            IRoom room;
            if(roomTypeName == nameof(Apartment))
            {
                room = new Apartment();
            }
            else if(roomTypeName == nameof(DoubleBed))
            {
                room = new DoubleBed();
            }
            else if(roomTypeName == nameof(Studio))
            {
                room = new Studio();
            }
            else
            {
                throw new ArgumentException("Incorrect room type!");
            }
            hotel.Rooms.AddNew(room);

            return $"Successfully added {roomTypeName} room type in {hotelName} hotel!";
        }
    }
}
