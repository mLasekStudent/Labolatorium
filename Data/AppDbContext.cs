using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }

        public DbSet<ReservationEntity> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = d:/contacts.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasKey(e => e.ContactId);
            modelBuilder.Entity<ContactEntity>()
                .HasData(
                    new ContactEntity() { ContactId = 1, Name = "Adam", Email = "adas@gmail.com", Phone = "123123123", Birth = new DateTime(2001, 11, 22), Priority = 3 },
                    new ContactEntity() { ContactId = 2, Name = "Ewa", Email = "ewcia@gmail.com", Phone = "123123321", Priority = 1 }
                );

            modelBuilder.Entity<ReservationEntity>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<ReservationEntity>()
                .HasData(
                    new ReservationEntity() { Id = 1, data = new DateTime(2024, 03, 30), miasto = "Kraków", adres = "Miodowa 2", pokoj = 24, wlasciciel = "Robert Makłowicz", cena = 399.00m },
                    new ReservationEntity() { Id = 2, data = new DateTime(2024, 02, 13), miasto = "Gdańsk", adres = "Masztowa 4", pokoj = 9, wlasciciel = "Krzysztof Krawczyk", cena = 449.00m }
                );
        }
    }
}
