using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Produto")]
    public class Producto
    {
        [Key]
        [Column("codigo")]
        [Display(Name ="Código")]
        public String codigo { get; set; }
        [Column("nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string nome { get; set; }
        [Column("descricao")]
        [Display(Name = "Descricão")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string descricao { get; set; }
        [Column("categoria")]
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public String categoria { get; set; }
        [Column("preco")]
        [Display(Name = "Preco")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double preco { get; set; }
        [Column("data_validade")]
        [Display(Name = "Data Validade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public String dataValidade { get; set; }
    }
}
