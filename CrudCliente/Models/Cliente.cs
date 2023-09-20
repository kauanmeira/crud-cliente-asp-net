using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCliente.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Column("EMAIL")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("SENHA")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("ENDERECO")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }
    }
}
