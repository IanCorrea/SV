using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Services
{
    public interface IVendaService : IServiceBase<Venda>
    {
        IEnumerable<Venda> BuscarPorPedido(int Id);
    }
}
