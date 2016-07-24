using AutoMapper;
using CadnunsDev.AngularECommerce.Application.ViewModels;
using CadnunsDev.AngularECommerce.Domain.Entities;

namespace CadnunsDev.AngularECommerce.Application.AutoMapper
{
    internal class ViewModelToDomainMappingProfile  : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}