using EntityFramework___Slider_task.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework___Slider_task.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
      


    }
}
