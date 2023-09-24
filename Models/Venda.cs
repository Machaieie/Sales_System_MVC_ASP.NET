using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        [Column("codigo")]
        [Display(Name = "Código")]
        public String codigo { get; set; }

        [Column("produto")]
        [Display(Name = "Produto")]
        [ForeignKey("produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String produto { get; set; }

        [Column("quantidade")]
        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String quantidade { get; set; }

        [Column("data_venda")]
        [Display(Name = "Data Venda")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String data_venda { get; set; }

        [Column("tipo_pagamento")]
        [Display(Name = "Tipo Pagamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String tipo_pagemento { get; set; }

        [Column("total")]
        [Display(Name = "Total")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public String total { get; set; }
    }
}
