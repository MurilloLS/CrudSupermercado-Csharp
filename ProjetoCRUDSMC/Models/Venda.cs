using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCRUDSMC.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Display(Name = "ID")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Nome do Produto")]
        [Column("NomeProduto")]
        public string NomeProduto { get; set; }


        [Display(Name = "Preço")]
        [Column("Preco")]
        public decimal Preco { get; set; }


        [Display(Name = "Quantidade")]
        [Column("Quantidade")]
        public int Quantidade { get; set; }


        [Display(Name = "Data da venda")]
        [Column("DataVenda")]
        public DateTime DataVenda { get; set; }


        [Display(Name = "Valor total")]
        [Column("ValorTotal")]
        public decimal ValorTotal { get; set; }
    }
}
