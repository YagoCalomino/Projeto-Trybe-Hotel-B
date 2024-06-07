using TrybeHotel.Models;
using TrybeHotel.Dto;
using Microsoft.EntityFrameworkCore;

namespace TrybeHotel.Repository
{
    public class HotelRepository : IHotelRepository
    {
        protected readonly ITrybeHotelContext _context;
        public HotelRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        public IEnumerable<HotelDto> GetHotels()
        {
            return _context.Hotels.Select(hotel => new HotelDto
            {
                HotelId = hotel.HotelId,
                Name = hotel.Name,
                Address = hotel.Address,
                CityId = hotel.CityId,
                CityName = hotel.City!.Name
            }).ToList();
        }
        
        public HotelDto AddHotel(Hotel hotel)
            {
                _context.Hotels.Add(hotel);
                _context.SaveChanges();

                var newlyCreatedHotel = _context.Hotels
                                            .Where(h => h.HotelId == hotel.HotelId)
                                            .Include(h => h.City)
                                            .FirstOrDefault();

                return new HotelDto
                {
                    HotelId = newlyCreatedHotel.HotelId,
                    Name = newlyCreatedHotel.Name,
                    Address = newlyCreatedHotel.Address,
                    CityId = newlyCreatedHotel.CityId,
                    CityName = newlyCreatedHotel.City!.Name
                };
            }
    }
}