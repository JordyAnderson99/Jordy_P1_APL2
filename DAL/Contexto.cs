using Jordy_P1_APL2.Models;
using Microsoft.EntityFrameworkCore;


namespace Jordy_P1_APL2.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/Productos.db");
        }
    }
}
