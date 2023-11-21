using Labolatorium_3___App.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3___App.Models
{
    public interface IReservationService
    {
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void DeleteById(Reservation reservation);
        Reservation? FindById(int id);
        List<Reservation> FindAll();
    }
}
