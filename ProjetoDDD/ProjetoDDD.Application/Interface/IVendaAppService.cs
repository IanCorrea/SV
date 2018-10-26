
using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Application.Interface
{
    public interface IVendaAppService : IAppServiceBase<Venda>
    {
        IEnumerable<Venda> BuscarPorPedido(int Id);
    }
}
