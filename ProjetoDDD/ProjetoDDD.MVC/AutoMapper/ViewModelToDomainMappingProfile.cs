using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Colaborador, ColaboradorViewModel>();
            CreateMap<Venda, VendaViewModel>();
        }
    }
}