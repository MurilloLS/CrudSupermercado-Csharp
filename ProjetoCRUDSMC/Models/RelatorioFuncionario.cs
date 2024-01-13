using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCRUDSMC.Models
{
    public class RelatorioFuncionario
    {
        [Display(Name = "ID")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "ID do funcionário")]
        [Column("FuncionarioId")]
        public int FuncionarioId { get; set; }


        [Display(Name = "Data do relatório")]
        [Column("DataRelatorio")]
        public DateTime DataRelatorio { get; set; }


        [Display(Name = "Relatório")]
        [Column("Relatorio")]
        public string Relatorio { get; set; }
    }
}
