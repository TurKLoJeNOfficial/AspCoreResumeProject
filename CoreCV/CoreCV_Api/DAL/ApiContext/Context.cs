using CoreCV_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreCV_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TF4LELE\\SQLEXPRESS;database=CoreCvDB2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
