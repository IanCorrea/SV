using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]        
        public int ClienteId { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Preencha o campo Nome Completo")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Números e caracteres especiais não são permitidos no campo Nome Completo.")]
        [MaxLength(40, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {1} caracteres")]
        public string Nome { get; set; }

        [DisplayName("Idade")]
        [Required(ErrorMessage = "Preencha o campo Idade")]
        [Range(1, 150, ErrorMessage = "A idade deve ser de 1 a 150 anos.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        public string Cpf { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]        
        public string Email { get; set; }

        public virtual IEnumerable<VendaViewModel> Vendas { get; set; }
    }
}