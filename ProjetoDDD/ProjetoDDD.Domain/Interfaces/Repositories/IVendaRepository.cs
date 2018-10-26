
using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IVendaRepository :IRepositoryBase<Venda>
    {
        IEnumerable<Venda> BuscarPorPedido(int id);
    }
}
