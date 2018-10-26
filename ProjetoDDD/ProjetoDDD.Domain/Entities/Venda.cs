using System;

namespace ProjetoDDD.Domain.Entities
{
    public class Venda
    {
        public int VendaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Pedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ColaboradorId { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
