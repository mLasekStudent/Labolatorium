using Data.Entities;
using Data;
using Labolatorium_3___App.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3___App.Models
{
    public class EFReservationService : IReservationService
    {
        private AppDbContext _context;

        public EFReservationService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Reservation reservation)
        {
            var e = _context.Reservations.Add(ReservationMapper.ToEntity(reservation));
            _context.SaveChanges();
        }

        public void DeleteById(Reservation reservation)
        {
            ReservationEntity? find = _context.Reservations.Find(reservation.Id);
            if (find != null)
            {
                _context.Reservations.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Reservation> FindAll()
        {
            return _context.Reservations.Select(e => ReservationMapper.FromEntity(e)).ToList(); ;
        }

        public Reservation? FindById(int id)
        {
            return ReservationMapper.FromEntity(_context.Reservations.Find(id));
        }

        public void Update(Reservation reservation)
        {
            _context.Reservations.Update(ReservationMapper.ToEntity(reservation));
            _context.SaveChanges();
        }
    }
}
