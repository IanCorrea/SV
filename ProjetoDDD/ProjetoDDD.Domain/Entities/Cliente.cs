using System.Collections.Generic;

namespace ProjetoDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<Venda> Vendas { get; set; }
    }
}
