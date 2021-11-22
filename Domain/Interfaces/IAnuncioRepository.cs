using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAnuncioRepository
    {
        Task<IEnumerable<Anuncio>> GetAnuncios();
        Task<Anuncio> GetById(int? id);

        void Add(Anuncio anuncio);
        void Update(Anuncio anuncio);
        void Remove(Anuncio anuncio);
    }
}
