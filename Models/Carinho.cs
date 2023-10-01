using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Carinho")]
    public class Carinho
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo VendaId é obrigatório.")]
        public int VendaId { get; set; }

        [Required(ErrorMessage = "O campo ProdutoId é obrigatório.")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O campo quantidade é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser um número maior ou igual a 1.")]
        public int quantidade { get; set; }

        [Required(ErrorMessage = "O campo Preco é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O Preço deve ser maior ou igual a 0.01.")]
        public double Preco { get; set; }

        [ForeignKey("VendaId")]
        public virtual Venda VendaModel { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Producto ProdutoModel { get; set; }
    }
}
