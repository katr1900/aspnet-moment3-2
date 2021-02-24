using Microsoft.EntityFrameworkCore;
using Moment32.Models;
using System;
using System.Collections.Generic;

namespace Moment32.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Song>().HasKey(a => a.Id);
            modelBuilder.Entity<Song>().Property(a => a.Id).ValueGeneratedOnAdd();

        }
    }
}
