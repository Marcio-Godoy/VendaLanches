using Lanches.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Snack> Snacks { get; set; }

    }
}
