﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AdventureNest.Core.Models;

namespace AdventureNest.Repository.Seeds
{
    public class PropertySeed : IEntityTypeConfiguration<Property>
    {
        string[] pathlist = { "path1", "path2", "path3", "path4", "path5" };


        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasData(
                new Property
                {
                    Id = 1,
                    Name = "Serdivan Villa",
                    Address = "Serdivan",
                    City = "Sakarya",
                    Country = "Turkey",
                    BookingType = "Full House",
                    CreatedDate = DateTime.Now,
                    Latitude = 0,
                    Longtitude = 0,
                    OwnerId = 1,
                    PhotographsPathList = pathlist,
                    PropertyType = "Villa",
                    BathroomCount = 5,
                    BedCount = 12,
                    BedroomCount = 6,
                    MaxGuestCount = 15,
                    IsRefrigerator = true,
                    IsTv = true,
                    IsCouch = true,
                    IsBed = true,
                    IsGasStove = true,
                    IsBlender = true,
                    IsCoffeeMaker = true,
                    IsMicrowave = true,
                    IsMixingBowl = true,
                    IsWashingMachine = true,
                    hasKitchen = true
                },
                new Property
                {
                    Id = 2,
                    Name = "Miami Villa",
                    Address = "Miami Beach",
                    City = "Miami",
                    Country = "USA",
                    BookingType = "Villa",
                    CreatedDate = DateTime.Now,
                    Latitude = 0,
                    Longtitude = 0,
                    OwnerId = 1,
                    PhotographsPathList = pathlist,
                    PropertyType = "Villa",
                    BathroomCount = 5,
                    BedCount = 8,
                    BedroomCount = 5,
                    MaxGuestCount = 10,
                    IsRefrigerator = true,
                    IsTv = true,
                    IsCouch = true,
                    IsBed = true,
                    IsGasStove = true,
                    IsBlender = true,
                    IsCoffeeMaker = true,
                    IsMicrowave = true,
                    IsMixingBowl = true,
                    IsWashingMachine = true,
                    hasKitchen = true
                },
                new Property
                {
                    Id = 3,
                    Name = "Istanbul Kadikoy House",
                    Address = "Kadikoy",
                    City = "Istanbul",
                    Country = "Turkey",
                    BookingType = "Full House",
                    CreatedDate = DateTime.Now,
                    Latitude = 0,
                    Longtitude = 0,
                    OwnerId = 2,
                    PhotographsPathList = pathlist,
                    PropertyType = "Flat",
                    BathroomCount = 1,
                    BedCount = 3,
                    BedroomCount = 4,
                    MaxGuestCount = 4,
                    IsRefrigerator = true,
                    IsTv = true,
                    IsCouch = true,
                    IsBed = true,
                    IsGasStove = true,
                    IsBlender = true,
                    IsCoffeeMaker = true,
                    IsMicrowave = true,
                    IsMixingBowl = true,
                    IsWashingMachine = true,
                    hasKitchen = true
                },
                new Property
                {
                    Id = 4,
                    Name = "Maldives Bungalow",
                    Address = "Sosun Magu",
                    City = "Hithadhoo",
                    Country = "Maldives",
                    BookingType = "Full House",
                    CreatedDate = DateTime.Now,
                    Latitude = 0,
                    Longtitude = 0,
                    OwnerId = 2,
                    PhotographsPathList = pathlist,
                    PropertyType = "Villa",
                    BathroomCount = 1,
                    BedCount = 2,
                    BedroomCount = 2,
                    MaxGuestCount = 4,
                    IsRefrigerator = true,
                    IsTv = true,
                    IsCouch = true,
                    IsBed = true,
                    IsGasStove = true,
                    IsBlender = true,
                    IsCoffeeMaker = true,
                    IsMicrowave = true,
                    IsMixingBowl = true,
                    IsWashingMachine = true,
                    hasKitchen = true
                },
                new Property
                {
                    Id = 5,
                    Name = "Sardinia Hotel Room",
                    Address = "Capitana",
                    City = "Cagliari",
                    Country = "Italy",
                    BookingType = "Full House",
                    CreatedDate = DateTime.Now,
                    Latitude = 0,
                    Longtitude = 0,
                    OwnerId = 3,
                    PhotographsPathList = pathlist,
                    PropertyType = "Hotel",
                    BathroomCount = 2,
                    BedCount = 2,
                    BedroomCount = 2,
                    MaxGuestCount = 3,
                    IsRefrigerator = true,
                    IsTv = true,
                    IsCouch = true,
                    IsBed = true,
                    IsGasStove = true,
                    IsBlender = true,
                    IsCoffeeMaker = true,
                    IsMicrowave = true,
                    IsMixingBowl = true,
                    IsWashingMachine = true,
                    hasKitchen = true
                },
                new Property
                {
                    Id = 6,
                    Name = "Paris Studio",
                    Address = "Champ-Elysee",
                    City = "Paris",
                    Country = "France",
                    BookingType = "Single Room",
                    CreatedDate = DateTime.Now,
                    Latitude = 0,
                    Longtitude = 0,
                    OwnerId = 3,
                    PhotographsPathList = pathlist,
                    PropertyType = "Flat",
                    BathroomCount = 1,
                    BedCount = 1,
                    BedroomCount = 1,
                    MaxGuestCount = 2,
                    IsRefrigerator = true,
                    IsTv = true,
                    IsCouch = true,
                    IsBed = true,
                    IsGasStove = true,
                    IsBlender = true,
                    IsCoffeeMaker = true,
                    IsMicrowave = true,
                    IsMixingBowl = true,
                    IsWashingMachine = true,
                    hasKitchen = true
                }
            );
        }
    }
}
