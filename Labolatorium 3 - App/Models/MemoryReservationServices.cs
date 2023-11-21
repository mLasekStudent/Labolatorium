using Labolatorium_3___App.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Loader;

namespace Labolatorium_3___App.Models
{
    public class MemoryReservationServices : IReservationService
    {
        private readonly Dictionary<int, Reservation> _reservation = new Dictionary<int, Reservation>()
        {

            {1, new Reservation() {Id=1, data = new DateTime(2023,12,6), miasto = "Sosnowiec", adres = "Kaliska 35", pokoj = 13, wlasciciel = "Robert Makłowicz", cena = 299.99m } },
            {2, new Reservation() {Id=2, data = new DateTime(2023,12,31), miasto = "Zakopane", adres = "Krupówki 3", pokoj = 24, wlasciciel = "Sławomir Zapała", cena = 2699.99m } }

        };
        private int _id = 3;
        public void Add(Reservation reservation)
        {
            reservation.Id = _id++;
            _reservation[reservation.Id] = reservation;
        }

        public void DeleteById(Reservation reservation)
        {
            _reservation.Remove(reservation.Id);
        }

        public List<Reservation> FindAll()
        {
            return _reservation.Values.OrderBy(reservation => reservation.data).ToList();
        }

        public Reservation? FindById(int id)
        {
            return _reservation[id];
        }

        public void Update(Reservation reservation)
        {
            _reservation[reservation.Id] = reservation;
        }
    }
}
