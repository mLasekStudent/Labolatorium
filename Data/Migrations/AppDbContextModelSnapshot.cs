﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "506baa16-af0e-4394-aa25-d5fde0794c3b",
                            ConcurrencyStamp = "506baa16-af0e-4394-aa25-d5fde0794c3b",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "bacab883-5845-4ce3-8ba2-45358fa1b2d7",
                            ConcurrencyStamp = "bacab883-5845-4ce3-8ba2-45358fa1b2d7",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "373595e8-cd49-4ce9-8c57-749fbf616979",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "96b604b3-caea-4389-8177-17934ba84459",
                            Email = "adam@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADAM@WSEI.EDU.PL",
                            NormalizedUserName = "ADAM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEm1A6GYp32rtlUCyL8rqx/DtitCA8pRBN5pA7rDYRduwBtL2qILpFtWjGyiqoL2Jw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a20f4b4b-70f4-4e58-adb3-65670fc4768f",
                            TwoFactorEnabled = false,
                            UserName = "adam"
                        },
                        new
                        {
                            Id = "a9e1de0a-6a67-4a82-a11f-3c84c128a644",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "82bd301e-01e6-4b54-b706-8357a9792a49",
                            Email = "ewa@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EWA@WSEI.EDU.PL",
                            NormalizedUserName = "EWA",
                            PasswordHash = "AQAAAAIAAYagAAAAEFPo6e2YW3yy2lCVp5rt7Ot/IKrkaNhtZnXtLa77JwdnwK5tHKnPeBcW7OFa/E3Yag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6cd0efa1-a7ee-40db-bd39-e444742a470a",
                            TwoFactorEnabled = false,
                            UserName = "ewa"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "373595e8-cd49-4ce9-8c57-749fbf616979",
                            RoleId = "506baa16-af0e-4394-aa25-d5fde0794c3b"
                        },
                        new
                        {
                            UserId = "a9e1de0a-6a67-4a82-a11f-3c84c128a644",
                            RoleId = "bacab883-5845-4ce3-8ba2-45358fa1b2d7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
