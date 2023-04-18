﻿// <auto-generated />
using System;
using AdventureNest.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdventureNest.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdventureNest.Core.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingStatus")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PublicationId");

                    b.ToTable("Bookings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookingDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6986),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6984),
                            CustomerId = 2,
                            DepartureDate = new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 1000m,
                            PublicationId = 1,
                            TotalPrice = 6000m
                        },
                        new
                        {
                            Id = 2,
                            BookingDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7090),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 9, 5, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7089),
                            CustomerId = 3,
                            DepartureDate = new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 4000m,
                            PublicationId = 2,
                            TotalPrice = 16000m
                        },
                        new
                        {
                            Id = 3,
                            BookingDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7102),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 10, 21, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7102),
                            CustomerId = 1,
                            DepartureDate = new DateTime(2023, 10, 27, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 800m,
                            PublicationId = 3,
                            TotalPrice = 48000m
                        },
                        new
                        {
                            Id = 4,
                            BookingDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7113),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7113),
                            CustomerId = 3,
                            DepartureDate = new DateTime(2023, 8, 10, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 1000m,
                            PublicationId = 4,
                            TotalPrice = 10000m
                        },
                        new
                        {
                            Id = 5,
                            BookingDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7124),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7124),
                            CustomerId = 1,
                            DepartureDate = new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 2500m,
                            PublicationId = 5,
                            TotalPrice = 15000m
                        },
                        new
                        {
                            Id = 6,
                            BookingDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7135),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 5, 8, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7135),
                            CustomerId = 2,
                            DepartureDate = new DateTime(2023, 5, 12, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 200m,
                            PublicationId = 6,
                            TotalPrice = 800m
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("BathroomCount")
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<int>("BedroomCount")
                        .HasColumnType("int");

                    b.Property<string>("BookingType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsChair")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDishwasher")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFridge")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSofa")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTv")
                        .HasColumnType("bit");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longtitude")
                        .HasColumnType("real");

                    b.Property<int>("MaxGuestCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PhotographsPathList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Properties", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Serdivan",
                            BathroomCount = 5,
                            BedCount = 12,
                            BedroomCount = 6,
                            BookingType = "Full House",
                            City = "Sakarya",
                            Country = "Turkey",
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7296),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 15,
                            Name = "Serdivan Villa",
                            OwnerId = 1,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Villa"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Miami Beach",
                            BathroomCount = 5,
                            BedCount = 8,
                            BedroomCount = 5,
                            BookingType = "Villa",
                            City = "Miami",
                            Country = "USA",
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7302),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 10,
                            Name = "Miami Villa",
                            OwnerId = 1,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Villa"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kadikoy",
                            BathroomCount = 1,
                            BedCount = 3,
                            BedroomCount = 4,
                            BookingType = "Full House",
                            City = "Istanbul",
                            Country = "Turkey",
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7304),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 4,
                            Name = "Istanbul Kadikoy House",
                            OwnerId = 2,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Flat"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Sosun Magu",
                            BathroomCount = 1,
                            BedCount = 2,
                            BedroomCount = 2,
                            BookingType = "Full House",
                            City = "Hithadhoo",
                            Country = "Maldives",
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7306),
                            IsChair = true,
                            IsDishwasher = false,
                            IsFridge = true,
                            IsSofa = false,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 4,
                            Name = "Maldives Bungalow",
                            OwnerId = 2,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Villa"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Capitana",
                            BathroomCount = 2,
                            BedCount = 2,
                            BedroomCount = 2,
                            BookingType = "Full House",
                            City = "Cagliari",
                            Country = "Italy",
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7308),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 3,
                            Name = "Sardinia Hotel Room",
                            OwnerId = 3,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Hotel"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Champ-Elysee",
                            BathroomCount = 1,
                            BedCount = 1,
                            BedroomCount = 1,
                            BookingType = "Single Room",
                            City = "Paris",
                            Country = "France",
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(7311),
                            IsChair = false,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = false,
                            IsTv = false,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 2,
                            Name = "Paris Studio",
                            OwnerId = 3,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Flat"
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Title");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("Publications", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6693),
                            Description = "Villa with Sapanca Lake view",
                            IsActive = true,
                            Price = 1000m,
                            PropertyId = 1,
                            Title = "Sakarya Lux Villa House"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6705),
                            Description = "Villa with Miami Beach view",
                            IsActive = true,
                            Price = 4000m,
                            PropertyId = 2,
                            Title = "Ultra Lux Villa in Miami"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6706),
                            Description = "A beautiful house in the center of Kadıköy",
                            IsActive = true,
                            Price = 800m,
                            PropertyId = 3,
                            Title = "Comfortable House in Kadikoy"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6707),
                            Description = "Ultra luxury all-inclusive accommodation by the ocean in the Maldives",
                            IsActive = true,
                            Price = 1000m,
                            PropertyId = 4,
                            Title = "Unique Villa with deep blue ocean view"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6708),
                            Description = "A hotel room in the unique beauty of the island of Sardinia",
                            IsActive = true,
                            Price = 2500m,
                            PropertyId = 5,
                            Title = "All inclusive hotel room with sea view"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 4, 18, 3, 8, 55, 844, DateTimeKind.Local).AddTicks(6709),
                            Description = "One room house",
                            IsActive = true,
                            Price = 200m,
                            PropertyId = 6,
                            Title = "Affordable studio home in Paris"
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Token", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "string1@hotmail.com",
                            FirstName = "string1",
                            LastName = "string1",
                            PasswordHash = new byte[] { 130, 109, 18, 54, 121, 200, 147, 55, 202, 54, 215, 243, 8, 250, 83, 231, 97, 28, 100, 90, 147, 234, 129, 73, 30, 234, 6, 122, 65, 255, 148, 207, 76, 89, 43, 249, 29, 128, 66, 177, 102, 95, 114, 17, 135, 166, 75, 54, 55, 177, 87, 178, 54, 106, 54, 201, 229, 37, 238, 211, 200, 122, 75, 103 },
                            PasswordSalt = new byte[] { 57, 233, 184, 221, 158, 69, 126, 55, 111, 94, 80, 148, 112, 53, 218, 94, 238, 189, 165, 62, 108, 99, 57, 215, 14, 84, 10, 213, 96, 123, 250, 221, 62, 226, 215, 28, 230, 34, 196, 95, 178, 215, 163, 13, 244, 69, 238, 43, 24, 44, 129, 236, 216, 125, 25, 254, 193, 55, 224, 39, 56, 195, 94, 193, 226, 155, 233, 18, 64, 62, 161, 71, 190, 145, 187, 60, 150, 119, 241, 66, 48, 58, 213, 159, 125, 170, 18, 186, 193, 32, 92, 1, 47, 206, 228, 218, 27, 133, 163, 59, 95, 182, 88, 229, 142, 175, 143, 46, 186, 37, 29, 115, 225, 9, 16, 180, 134, 222, 25, 45, 25, 237, 36, 191, 194, 7, 69, 106 },
                            Picture = "string1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 8, 8, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "string2@hotmail.com",
                            FirstName = "string2",
                            LastName = "string2",
                            PasswordHash = new byte[] { 74, 0, 241, 138, 72, 244, 201, 9, 44, 87, 250, 23, 107, 32, 106, 192, 113, 35, 26, 166, 228, 50, 12, 242, 87, 187, 193, 89, 129, 197, 83, 192, 1, 40, 0, 61, 15, 225, 153, 127, 33, 37, 240, 8, 220, 213, 75, 157, 235, 69, 195, 55, 59, 170, 133, 172, 169, 136, 166, 167, 202, 70, 156, 234 },
                            PasswordSalt = new byte[] { 193, 150, 191, 164, 177, 115, 12, 74, 80, 205, 138, 188, 133, 172, 80, 229, 137, 90, 129, 252, 159, 50, 5, 252, 246, 183, 229, 11, 92, 189, 45, 149, 244, 36, 14, 150, 72, 36, 226, 159, 250, 120, 93, 224, 138, 140, 24, 56, 248, 212, 69, 84, 249, 31, 84, 253, 253, 150, 5, 184, 163, 32, 115, 1, 187, 253, 182, 96, 31, 251, 90, 209, 176, 247, 218, 7, 54, 251, 85, 190, 214, 232, 158, 41, 49, 153, 57, 221, 53, 51, 108, 157, 10, 8, 120, 150, 206, 238, 208, 49, 119, 50, 210, 139, 223, 136, 20, 234, 118, 97, 85, 83, 233, 173, 185, 122, 173, 207, 205, 9, 174, 255, 81, 10, 192, 142, 211, 246 },
                            Picture = "string2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "string3@hotmail.com",
                            FirstName = "string3",
                            LastName = "string3",
                            PasswordHash = new byte[] { 37, 3, 169, 17, 30, 11, 78, 206, 168, 12, 182, 210, 144, 134, 130, 60, 29, 122, 137, 146, 31, 60, 129, 19, 21, 38, 101, 139, 229, 9, 203, 166, 71, 77, 109, 48, 102, 248, 79, 181, 237, 29, 42, 86, 73, 41, 174, 159, 50, 192, 105, 148, 233, 239, 227, 144, 22, 92, 0, 52, 31, 189, 13, 52 },
                            PasswordSalt = new byte[] { 116, 46, 6, 76, 4, 66, 203, 20, 149, 120, 78, 164, 192, 209, 175, 219, 134, 10, 184, 7, 246, 9, 119, 65, 24, 195, 20, 77, 150, 167, 68, 231, 100, 95, 160, 95, 28, 20, 101, 9, 148, 78, 0, 112, 213, 94, 45, 37, 46, 30, 3, 205, 57, 191, 173, 239, 144, 84, 50, 220, 5, 232, 172, 57, 161, 164, 179, 156, 252, 13, 93, 138, 121, 155, 37, 78, 217, 97, 101, 243, 116, 21, 225, 229, 241, 201, 109, 216, 188, 236, 113, 126, 27, 144, 41, 221, 39, 179, 186, 8, 62, 238, 194, 151, 105, 246, 22, 75, 206, 175, 173, 196, 117, 109, 156, 223, 42, 34, 23, 241, 224, 98, 148, 11, 105, 83, 85, 178 },
                            Picture = "string3"
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Booking", b =>
                {
                    b.HasOne("AdventureNest.Core.Models.Publication", "Publication")
                        .WithMany("Bookings")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Property", b =>
                {
                    b.HasOne("AdventureNest.Core.Models.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Publication", b =>
                {
                    b.HasOne("AdventureNest.Core.Models.Property", "Property")
                        .WithOne("Publication")
                        .HasForeignKey("AdventureNest.Core.Models.Publication", "PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Property", b =>
                {
                    b.Navigation("Publication")
                        .IsRequired();
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Publication", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.User", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
