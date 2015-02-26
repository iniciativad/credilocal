using AutoMapper;
using CrediLocal.Domain.Entities;
using CrediLocal.Mvc.ViewModels;

namespace CrediLocal.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}