using TrybeHotel.Models;
using TrybeHotel.Dto;
using Microsoft.EntityFrameworkCore;

namespace TrybeHotel.Repository
{
    public class BookingRepository : IBookingRepository
    {
        protected readonly ITrybeHotelContext _context;
        public BookingRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        public BookingResponse Add(BookingDtoInsert booking, string email)
        {
            var room = _context.Rooms
                .Include(r => r.Hotel)
                    .ThenInclude(h => h.City)
                .FirstOrDefault(r => r.RoomId == booking.RoomId);
            var user = _context.Users.FirstOrDefault(u => u.Email == email);

            if (room == null)
                throw new Exception("Room not found");

            if (user == null)
                throw new Exception("User not found");

            if (booking.GuestQuant > room.Capacity)
                throw new Exception("Guest quantity exceeds room capacity");

            var newBooking = new Booking
            {
                CheckIn = booking.CheckIn,
                CheckOut = booking.CheckOut,
                GuestQuant = booking.GuestQuant,
                RoomId = booking.RoomId,
                UserId = user.UserId
            };

            _context.Bookings.Add(newBooking);
            _context.SaveChanges();

            var roomDto = new RoomDto
            {
                RoomId = room.RoomId,
                Name = room.Name,
                Capacity = room.Capacity,
                Image = room.Image,
                Hotel = new HotelDto
                {
                    HotelId = room.Hotel.HotelId,
                    Name = room.Hotel.Name,
                    Address = room.Hotel.Address,
                    CityId = room.Hotel.CityId,
                    CityName = room.Hotel.City.Name
                }
            };

            return new BookingResponse
            {
                BookingId = newBooking.BookingId,
                CheckIn = newBooking.CheckIn,
                CheckOut = newBooking.CheckOut,
                GuestQuant = newBooking.GuestQuant,
                Room = roomDto
            };
        }

        public BookingResponse GetBooking(int bookingId, string email)
        {
            var booking = _context.Bookings
                .Include(b => b.Room)
                    .ThenInclude(r => r.Hotel)
                        .ThenInclude(h => h.City)
                .FirstOrDefault(b => b.BookingId == bookingId && b.User.Email == email);

            if (booking == null)
                throw new Exception("Unauthorized");

            var roomDto = new RoomDto
            {
                RoomId = booking.Room.RoomId,
                Name = booking.Room.Name,
                Capacity = booking.Room.Capacity,
                Image = booking.Room.Image,
                Hotel = new HotelDto
                {
                    HotelId = booking.Room.Hotel.HotelId,
                    Name = booking.Room.Hotel.Name,
                    Address = booking.Room.Hotel.Address,
                    CityId = booking.Room.Hotel.CityId,
                    CityName = booking.Room.Hotel.City.Name
                }
            };

            return new BookingResponse
            {
                BookingId = booking.BookingId,
                CheckIn = booking.CheckIn,
                CheckOut = booking.CheckOut,
                GuestQuant = booking.GuestQuant,
                Room = roomDto
            };
        }

        public Room GetRoomById(int RoomId)
        {
            throw new NotImplementedException();
        }

    }

}