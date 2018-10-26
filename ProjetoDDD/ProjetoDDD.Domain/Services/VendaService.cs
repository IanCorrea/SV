using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;

namespace ProjetoDDD.Domain.Services
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
            : base(vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IEnumerable<Venda> BuscarPorPedido(int Id)
        {
            return _vendaRepository.BuscarPorPedido(Id);
        }
    }
}
