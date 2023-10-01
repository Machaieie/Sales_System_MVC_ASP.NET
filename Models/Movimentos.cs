using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Movimentos")]
    public class Movimentos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo StockId é obrigatório.")]
        public int StockId { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "A Quantidade deve ser um número maior ou igual a 1.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [ForeignKey("StockId")]
        public virtual Estoque StockModel { get; set; }
    }
}
