using System.Collections.Generic;

namespace ProjetoDDD.Domain.Entities
{
    public class Colaborador
    {
        public int ColaboradorId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Apelido { get; set; }
        public string Sexo { get; set; }
        public virtual IEnumerable<Venda> Vendas { get; set; }
    }
}
