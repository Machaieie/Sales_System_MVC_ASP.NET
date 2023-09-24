using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [Key]
        [Column("codigo")]
        [Display (Name ="Código")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public String codigo { get; set; }

        [Column("produto")]
        [Display (Name="Produto")]
        [Required (ErrorMessage ="O campo {0} é obrigatório")]
        public String produto { get; set; }

        [Column("quantidade")]
        [Display (Name ="Quantidade")]
        [Required (ErrorMessage ="O campo {0} é obrigatorio")]
        public String quantidade { get; set;}

        [Column("data_stock")]
        [Display(Name = "Data Stoque")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String data_stoque { get; set; }


        [Column("valor")]
        [Display(Name = "Valor Estoque")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String valor { get; set; }

        [Column("fornecedor")]
        [Display(Name = "Fornecedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String fornecedor { get; set; }


    }
}
