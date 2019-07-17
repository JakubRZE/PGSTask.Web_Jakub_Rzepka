using Microsoft.EntityFrameworkCore;
using PGSTask.Web_Jakub_Rzepka.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PGSTask.Web_Jakub_Rzepka.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>().HasData(
                new UserTask { Id = 1, Description = "Test task 3463", CreatedAt = DateTime.Now },
                new UserTask { Id = 2, Description = "Test task 3456", CreatedAt = DateTime.Now },
                new UserTask { Id = 3, Description = "Test task 2345", CreatedAt = DateTime.Now },
                new UserTask { Id = 4, Description = "Test task 3465", CreatedAt = DateTime.Now },
                new UserTask { Id = 5, Description = "Test task 4566", CreatedAt = DateTime.Now },
                new UserTask { Id = 6, Description = "Test task 3456", CreatedAt = DateTime.Now },
                new UserTask { Id = 7, Description = "Test task 2456", CreatedAt = DateTime.Now },
                new UserTask { Id = 8, Description = "Test task 1356", CreatedAt = DateTime.Now }
            );
        }
    }
}
