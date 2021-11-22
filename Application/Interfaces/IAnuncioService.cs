using Application.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAnuncioService
    {
        Task<IEnumerable<AnuncioViewModel>> GetAnuncios();
        Task<AnuncioViewModel> GetById(int? id);

        void Add(AnuncioViewModel anuncio);
        void Update(AnuncioViewModel anuncio);
        void Remove(AnuncioViewModel anuncio);
        List<SelectListItem> GetMarcas();
    }
}
