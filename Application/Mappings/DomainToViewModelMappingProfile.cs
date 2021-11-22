using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Anuncio, AnuncioViewModel>();
        }
    }
}
