using Ninject.Modules;
using ProjetoDDD.Application;
using ProjetoDDD.Application.Interface;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Services;
using ProjetoDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.CrossCutting
{
    public class CrossCuttingModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(IAppServiceBase<>));
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IColaboradorAppService>().To<ColaboradorAppService>();
            Bind<IVendaAppService>().To<VendaAppService>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IColaboradorService>().To<ColaboradorService>();
            Bind<IVendaService>().To<VendaService>();

            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IColaboradorRepository>().To<ColaboradorRepository>();
            Bind<IVendaRepository>().To<VendaRepository>();
        }        
    }
}
