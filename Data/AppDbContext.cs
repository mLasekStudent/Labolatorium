using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
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


            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();

            // dodanie roli administratora
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            // utworzenie administratora jako użytkownika
            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "adam@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "adam",
                NormalizedUserName = "ADMIN"
            };

            // haszowanie hasła
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "1234abcd!@#$ABCD");

            // zapisanie użytkownika
            modelBuilder.Entity<IdentityUser>().HasData(admin);

            // przypisanie roli administratora użytkownikowi
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            // dodanie roli administratora
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "user",
                NormalizedName = "USER",
                Id = USER_ROLE_ID,
                ConcurrencyStamp = USER_ROLE_ID
            });

            // utworzenie administratora jako użytkownika
            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "ewa@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "ewa",
                NormalizedUserName = "USER"
            };

            // haszowanie hasła
            PasswordHasher<IdentityUser> uph = new PasswordHasher<IdentityUser>();
            user.PasswordHash = uph.HashPassword(user, "abcd1234!@#$");

            // zapisanie użytkownika
            modelBuilder.Entity<IdentityUser>().HasData(user);

            // przypisanie roli administratora użytkownikowi
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });
        }
    }
}
