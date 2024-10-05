using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelRating.Models;

namespace HotelRating.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);

            // افزودن داده‌های نمونه برای هتل‌ها
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Hotel A", Address = "Address A" },
                new Hotel { Id = 2, Name = "Hotel B", Address = "Address B" }
            );

            // افزودن داده‌های نمونه برای سوالات
            modelBuilder.Entity<Question>().HasData(
                new Question { Id = 1, Text = "How would you rate the cleanliness?", Type = "Rating", HotelId = 1 },
                new Question { Id = 2, Text = "Was the staff friendly?", Type = "YesNo", HotelId = 1 },
                new Question { Id = 3, Text = "Any comments about your stay?", Type = "OpenEnded", HotelId = 1 },
                new Question { Id = 4, Text = "How would you rate the service?", Type = "Rating", HotelId = 2 },
                new Question { Id = 5, Text = "Would you recommend this hotel?", Type = "YesNo", HotelId = 2 }
            );
        }
    }
}
