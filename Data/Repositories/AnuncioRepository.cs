using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AnuncioRepository : IAnuncioRepository
    {
        ApplicationDbContext _context;
        public AnuncioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Anuncio anuncio)
        {
            _context.Add(anuncio);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Anuncio>> GetAnuncios()
        {
            return await _context.Anuncios.ToListAsync();
        }

        public async Task<Anuncio> GetById(int? id)
        {
            return await _context.Anuncios.FindAsync(id);
        }

        public void Remove(Anuncio anuncio)
        {
            _context.Remove(anuncio);
            _context.SaveChanges();
        }

        public void Update(Anuncio anuncio)
        {
            _context.Update(anuncio);
            _context.SaveChanges();
        }
    }
}
