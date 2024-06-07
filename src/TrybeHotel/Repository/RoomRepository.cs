using TrybeHotel.Models;
using TrybeHotel.Dto;
using Microsoft.EntityFrameworkCore;

namespace TrybeHotel.Repository
{
    public class RoomRepository : IRoomRepository
    {
        protected readonly ITrybeHotelContext _context;
        public RoomRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

public IEnumerable<RoomDto> GetRooms(int hotelId)
{
    return _context.Rooms
                   .Where(r => r.HotelId == hotelId)
                   .Include(r => r.Hotel)
                   .Select(room => new RoomDto
                   {
                       RoomId = room.RoomId,
                       Name = room.Name,
                       Capacity = room.Capacity,
                       Image = room.Image,
                       Hotel = new HotelDto
                       {
                           HotelId = room.Hotel!.HotelId,
                           Name = room.Hotel.Name,
                           Address = room.Hotel.Address,
                           CityId = room.Hotel.CityId,
                           CityName = room.Hotel.City!.Name
                       }
                   }).ToList();
}

        public RoomDto AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();

            return _context.Rooms.Where(r => r.RoomId == room.RoomId).Select(room => new RoomDto
            {
                RoomId = room.RoomId,
                Name = room.Name,
                Capacity = room.Capacity,
                Image = room.Image,
                Hotel = new HotelDto
                {
                    HotelId = room.Hotel!.HotelId,
                    Name = room.Hotel.Name,
                    Address = room.Hotel.Address,
                    CityId = room.Hotel.CityId,
                    CityName = room.Hotel.City!.Name
                }
            }).First();
        }

        public void DeleteRoom(int roomId)
        {
            var room = _context.Rooms.Include(r => r.Hotel).FirstOrDefault(r => r.RoomId == roomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges(); 
            }
        }
    }
}