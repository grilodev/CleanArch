using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AnuncioViewModel, Anuncio>();
        }
    }
}
