﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_de_vendas.Models
{
    [Table("Usuarios")]
    public class User
    {
        [Key]
        [Column("id")]
        [Display(Name = "ID")]
        
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Column("usuario")]
        [Display (Name ="Usuario")]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        [Column("senha")]
        [Display(Name = "Senha")]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        [Column("tipousuario")]
        [Display(Name = "Tipo de Usuario")]
        public string Role { get; set;}

    }
}
