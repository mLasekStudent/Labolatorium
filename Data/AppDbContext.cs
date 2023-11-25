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
                    new ContactEntity()
                    {
                        ContactId = 1,
                        Name = "Test",
                        Email = "test@wsei.edu.pl",
                        Phone = "123123123",
                        Priority = 1,
                    },
                    new ContactEntity()
                    {
                        ContactId = 2,
                        Name = "Ewa",
                        Email = "ewa@wsei.edu.pl",
                        Phone = "123123321",
                        Priority = 3,
                        Birth = new DateTime(2000, 10, 10)
                    }
                );
        }
    }
}
