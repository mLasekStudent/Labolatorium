using Labolatorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3___App.Controllers
{
    [Authorize(Roles = "admin")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;


        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_reservationService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Reservation model)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Add(model);
                return RedirectToAction("Index");
            }
            return View();

        }
        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_reservationService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details(Reservation model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();

        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_reservationService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Reservation model)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_reservationService.FindById(id));
        }
        [HttpPost]
        public IActionResult Delete(Reservation model)
        {
            var reservationToDelete = _reservationService.FindById(model.Id);

            if (reservationToDelete != null)
            {
                _reservationService.DeleteById(reservationToDelete);
                return RedirectToAction("Index");
            }

            return NotFound();
        }


    }
}