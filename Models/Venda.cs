using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Venda")]
    public class Venda
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Status é obrigatório.")]
        [Range(1, 3, ErrorMessage = "O campo Status deve estar entre 1 e 3.")]
        public int Status { get; set; }

        [Required(ErrorMessage = "O campo PrecoPago é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O campo PrecoPago deve ser maior ou igual a 0.")]
        public double PrecoPago { get; set; }
    }
}
