using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Produto")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string? Nome { get; set; }

        [StringLength(200, ErrorMessage = "O campo Descrição deve ter no máximo 200 caracteres.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public string Categoria { get; set; }
    }
}
