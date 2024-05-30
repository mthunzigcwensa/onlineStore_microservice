using Microsoft.EntityFrameworkCore;
using Online.Services.RewardAPI.Models;

namespace Online.Services.RewardAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Rewards> Rewards { get; set; }


    }
}
