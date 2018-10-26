using ProjetoDDD.Application.Interface;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Services;

namespace ProjetoDDD.Application
{
    public class ColaboradorAppService : AppServiceBase<Colaborador>, IColaboradorAppService
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorAppService(IColaboradorService colaboradorService)
            : base(colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }
    }
}
