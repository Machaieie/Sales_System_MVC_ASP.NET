using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo ProdutoId é obrigatório.")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "A Quantidade deve ser um número maior ou igual a 1.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O campo Preco é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O Preço  deve ser maior ou igual a 0.01.")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "O campo Descricao é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "A Descricao  deve ser maior ou igual a 0.01.")]
        public double Descricao { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Producto ProdutoModel { get; set; }

    }
}
