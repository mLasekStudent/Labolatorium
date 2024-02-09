using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labolatorium_3___App.Controllers;
using Labolatorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;

namespace Labolatorium_3___App.Tests.Controllers
{
    [TestClass]
    public class ReservationControllerTest
    {
        private ReservationController _controller;
        private AppDbContext _context;

        [TestInitialize]
        public void Setup()
        {
            _context = CreateDbContext();
            _controller = new ReservationController(new EFReservationService(_context));
        }

        [TestMethod]
        public void TestIndexView()
        {
            // Act
            var result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void TestCreateViewWithModel()
        {
            // Arrange
            var reservation = new Reservation
            {
                Id = 3,
                data = new DateTime(2025, 03, 10),
                miasto = "Warszawa",
                adres = "Mostowa 1",
                pokoj = 1,
                wlasciciel = "Jan Kowalski",
                cena = 50.00m
            };

            // Act
            var result = _controller.Create(reservation) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Create", result.ViewName);
            Assert.AreEqual(reservation, result.Model);
        }

        [TestMethod]
        public void TestDeleteRedirectToIndex()
        {
            // Arrange
            var reservation = new Reservation { Id = 1 };

            // Act
            var result = _controller.Delete(reservation) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ActionName);
        }

        private AppDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new AppDbContext(options);

            context.Reservations.AddRange(new List<ReservationEntity>
            {
                new ReservationEntity { Id = 1, data = new DateTime(2024, 03, 30), miasto = "Kraków", adres = "Miodowa 2", pokoj = 24, wlasciciel = "Robert Mak³owicz", cena = 399.00m },
                new ReservationEntity { Id = 2, data = new DateTime(2024, 02, 13), miasto = "Gdañsk", adres = "Masztowa 4", pokoj = 9, wlasciciel = "Krzysztof Krawczyk", cena = 449.00m }
            });

            context.SaveChanges();

            return context;
        }
    }
}
