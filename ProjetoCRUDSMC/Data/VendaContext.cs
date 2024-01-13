using Microsoft.EntityFrameworkCore;
using ProjetoCRUDSMC.Models;

namespace ProjetoCRUDSMC.Data
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext> options) :base(options)
        {
            
        }

        public DbSet<Venda> Vendas { get; set; }
    }
}
