using System.Collections.Generic;
using ProjetoDDD.Application.Interface;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Services;


namespace ProjetoDDD.Application
{
    public class VendaAppService : AppServiceBase<Venda>, IVendaAppService
    {
        private readonly IVendaService _vendaService;

        public VendaAppService(IVendaService vendaService)
            : base(vendaService)
        {
            _vendaService = vendaService;
        }

        public IEnumerable<Venda> BuscarPorPedido(int id)
        {
            return _vendaService.BuscarPorPedido(id);
        }
    }
}
