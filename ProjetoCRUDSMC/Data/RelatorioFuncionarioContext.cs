using Microsoft.EntityFrameworkCore;
using ProjetoCRUDSMC.Models;

namespace ProjetoCRUDSMC.Data
{
    public class RelatorioFuncionarioContext : DbContext
    {
        public RelatorioFuncionarioContext(DbContextOptions<RelatorioFuncionarioContext> options) :base(options)
        {
            
        }

        public DbSet<RelatorioFuncionario> RelatorioFuncionarios { get; set; }
    }
}
