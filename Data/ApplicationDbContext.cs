﻿using Lab3CityProvince.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab3CityProvince.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    builder.Entity<Province>().Property(m => m.ProvinceCode).IsRequired();

    builder.Entity<City>().Property(p => p.CityName).HasMaxLength(30);

    builder.Entity<City>().ToTable("City");
    builder.Entity<Province>().ToTable("Province");

    builder.Seed();
} 



    public DbSet<City>? Cities { get; set; }
    public DbSet<Province>? Provinces { get; set; }
}
