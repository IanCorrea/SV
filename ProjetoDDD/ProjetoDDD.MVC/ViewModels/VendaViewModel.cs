using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDDD.MVC.ViewModels
{
    public class VendaViewModel
    {
        [Key]        
        public int VendaId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Pedido")]
        [Range(1, 99999)]
        [Required(ErrorMessage = "Preencha o campo Pedido")]
        public int Pedido { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Sem preço")]        
        [Required(ErrorMessage = "Preencha o campo Valor")]        
        public decimal ValorTotal { get; set; }

        [DisplayName("Cliente")]
        [Required(ErrorMessage = "Selecione um Cliente")]
        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        [DisplayName("Vendedor")]
        [Required(ErrorMessage = "Selecione um Colaborador")]
        public int ColaboradorId { get; set; }

        public virtual ColaboradorViewModel Colaborador { get; set; }
    }
}