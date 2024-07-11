using Microsoft.EntityFrameworkCore;

namespace TiendaMicroservicios.Api.Cupon.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<TiendaMicroservicios.Api.Cupon.Models.Cupon> Cupons { get; set; }
    }
}
