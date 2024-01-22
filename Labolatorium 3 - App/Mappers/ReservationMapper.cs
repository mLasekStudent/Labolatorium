using Labolatorium_3___App.Models;
using Data;
using Data.Entities;

namespace Labolatorium_3___App.Mappers
{
    public class ReservationMapper
    {
        public static Reservation FromEntity(ReservationEntity entity)
        {
            return new Reservation()
            {
                Id = entity.Id,
                data = entity.data,
                miasto = entity.miasto,
                adres = entity.adres,
                pokoj = entity.pokoj,
                wlasciciel = entity.wlasciciel,
                cena = entity.cena,
            };
        }

        public static ReservationEntity ToEntity(Reservation model)
        {
            return new ReservationEntity()
            {
                Id = model.Id,
                data = model.data,
                miasto = model.miasto,
                adres = model.adres,
                pokoj = model.pokoj,
                wlasciciel = model.wlasciciel,
                cena = model.cena,
            };
        }
    }
}
