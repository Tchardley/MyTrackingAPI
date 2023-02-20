using Microsoft.EntityFrameworkCore;
using MyTrackingAPI.Models;

namespace MyTrackingAPI.Data
{
    public class TrackingDbContext: DbContext
    {
        public TrackingDbContext(DbContextOptions<TrackingDbContext> options): base(options)
        {

        }

        public DbSet<Issue> Issues { get; set; }

    }
}
