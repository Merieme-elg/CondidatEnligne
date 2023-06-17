using Condidature.Models;
using Microsoft.EntityFrameworkCore;

namespace Condidature.DBContext
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Condidat> Condidats { get; set; }   


    }

}
