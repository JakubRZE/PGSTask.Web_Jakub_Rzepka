using Microsoft.EntityFrameworkCore;
using PGSTask.Web_Jakub_Rzepka.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PGSTask.Web_Jakub_Rzepka.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}
