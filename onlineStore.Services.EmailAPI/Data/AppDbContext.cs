using Microsoft.EntityFrameworkCore;
using onlineStore.Services.EmailAPI.Models;

namespace onlineStore.Services.EmailAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EmailLogger> EmailLoggers { get; set; }


    }
}
