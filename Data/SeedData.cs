using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3CityProvince.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3CityProvince.Data;
public static class SeedData
{
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );

        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City
            {
                CityId = 1,
                CityName = "Vancouver",
                Population = 12423432,
                ProvinceCode = "BC",
            },
            new City
            {
                CityId = 2,
                CityName = "Kelowna",
                Population = 1242232,
                ProvinceCode = "BC",
            },
            new City
            {
                CityId = 3,
                CityName = "Victoria",
                Population = 2324243,
                ProvinceCode = "BC",
            },
            new City
            {
                CityId = 4,
                CityName = "Calgary",
                Population = 2342343,
                ProvinceCode = "AB",
            },
            new City
            {
                CityId = 5,
                CityName = "Edmonton",
                Population = 6453453,
                ProvinceCode = "AB",
            },
            new City
            {
                CityId = 6,
                CityName = "Red Deer",
                Population = 2345454,
                ProvinceCode = "AB",
            },
           
        };

        return cities;
    }

    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
            new Province
            {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            },
            new Province
            {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province
            {
                ProvinceCode = "MB",
                ProvinceName = "Manitoba"
            },
            new Province
            {
                ProvinceCode = "NB",
                ProvinceName = "New Brunswick"
            },
            new Province
            {
                ProvinceCode = "NL",
                ProvinceName = "Newfoundland and Labrador"
            },
            new Province
            {
                ProvinceCode = "NS",
                ProvinceName = "Nova Scotia"
            },
            new Province
            {
                ProvinceCode = "ON",
                ProvinceName = "Ontario"
            },
            new Province
            {
                ProvinceCode = "PE",
                ProvinceName = "Prince Edward Island"
            },
            new Province
            {
                ProvinceCode = "QC",
                ProvinceName = "Quebec"
            },
            new Province
            {
                ProvinceCode = "SK",
                ProvinceName = "Saskatchewan"
            }
        };

        return provinces;
    }
}
