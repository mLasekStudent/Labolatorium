﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240124194351_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data_ur");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Imie");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("Nr_tel");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContactId");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Birth = new DateTime(2001, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adas@gmail.com",
                            Name = "Adam",
                            Phone = "123123123",
                            Priority = 3
                        },
                        new
                        {
                            ContactId = 2,
                            Email = "ewcia@gmail.com",
                            Name = "Ewa",
                            Phone = "123123321",
                            Priority = 1
                        });
                });

            modelBuilder.Entity("Data.Entities.ReservationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("Adres");

                    b.Property<decimal>("cena")
                        .HasColumnType("TEXT")
                        .HasColumnName("Cena");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT")
                        .HasColumnName("Data");

                    b.Property<string>("miasto")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT")
                        .HasColumnName("Miasto");

                    b.Property<int>("pokoj")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Pokój");

                    b.Property<string>("wlasciciel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Właściciel");

                    b.HasKey("Id");

                    b.ToTable("reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            adres = "Miodowa 2",
                            cena = 399.00m,
                            data = new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            miasto = "Kraków",
                            pokoj = 24,
                            wlasciciel = "Robert Makłowicz"
                        },
                        new
                        {
                            Id = 2,
                            adres = "Masztowa 4",
                            cena = 449.00m,
                            data = new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            miasto = "Gdańsk",
                            pokoj = 9,
                            wlasciciel = "Krzysztof Krawczyk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
