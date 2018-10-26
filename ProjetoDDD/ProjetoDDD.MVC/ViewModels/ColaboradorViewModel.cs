using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDDD.MVC.ViewModels
{
    public class ColaboradorViewModel
    {
        [Key]        
        public int ColaboradorId { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Números e caracteres especiais não são permitidos no campo Nome Completo.")]
        [MaxLength(40, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {1} caracteres")]
        public string Nome { get; set; }

        [DisplayName("Idade")]
        [Required(ErrorMessage = "Preencha o campo Idade")]
        [Range(1, 150, ErrorMessage = "A idade deve ser de 1 a 150 anos.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Apelido")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Números e caracteres especiais não são permitidos no campo Apelido.")]
        [MaxLength(20, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {1} caracteres")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sexo")]
        [MaxLength(1, ErrorMessage = "Máximo {1} caracteres")]        
        public string Sexo { get; set; }

        public virtual IEnumerable<VendaViewModel> Vendas { get; set; }
    }
}