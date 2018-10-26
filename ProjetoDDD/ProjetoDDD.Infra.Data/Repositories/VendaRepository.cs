using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using System.Linq;


namespace ProjetoDDD.Infra.Data.Repositories
{
    public class VendaRepository : RepositoryBase<Venda>, IVendaRepository
    {
        public IEnumerable<Venda> BuscarPorPedido(int id)
        {
            return Db.Vendas.Where(p => p.VendaId == id);
        }
    }
}
