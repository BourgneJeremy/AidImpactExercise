using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactExercise.Models
{
    public class PointDataContext : DbContext
    {
        public DbSet<Point> Points { get; set; }

        /// <summary>
        /// Context for Entity Framework database
        /// </summary>
        /// <param name="options"></param>
        public PointDataContext(DbContextOptions<PointDataContext> options)
            : base(options)
        {
            // Verify that the database has been created
            Database.EnsureCreated();
        }
    }
}
