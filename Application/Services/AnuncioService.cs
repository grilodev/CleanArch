using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AnuncioService : IAnuncioService
    {
        private IAnuncioRepository _anuncioRepository;
        private readonly IMapper _mapper;

        public AnuncioService(IMapper autoMapper, IAnuncioRepository anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
            _mapper = autoMapper;
        }

        public void Add(AnuncioViewModel anuncio)
        {
            var mapAnuncio = _mapper.Map<Anuncio>(anuncio);
            _anuncioRepository.Add(mapAnuncio);
        }

        public async Task<IEnumerable<AnuncioViewModel>> GetAnuncios()
        {
            var result = await _anuncioRepository.GetAnuncios();
            return _mapper.Map<IEnumerable<AnuncioViewModel>>(result);
        }

        public async Task<AnuncioViewModel> GetById(int? id)
        {
            var result = await _anuncioRepository.GetById(id);
            return _mapper.Map<AnuncioViewModel>(result);
        }

        public void Remove(AnuncioViewModel anuncio)
        {
            var mapAnuncio = _mapper.Map<Anuncio>(anuncio);
            _anuncioRepository.Remove(mapAnuncio);
        }

        public void Update(AnuncioViewModel anuncio)
        {
            var mapAnuncio = _mapper.Map<Anuncio>(anuncio);
            _anuncioRepository.Update(mapAnuncio);
        }

        public List<SelectListItem> GetMarcas()
        {
            var model = new List<SelectListItem>() { 
                new SelectListItem() { Text = "", Value = "" },
                new SelectListItem() { Text = "Chevrolet", Value = "Chevrolet" },
                new SelectListItem() { Text = "Volkswagen", Value = "Volkswagen" },
                new SelectListItem() { Text = "Hyundai", Value = "Hyundai" },
                new SelectListItem() { Text = "Peugeot", Value = "Peugeot" },
                new SelectListItem() { Text = "Ford", Value = "Ford" },
                new SelectListItem() { Text = "Renault", Value = "Renault" }
            };

            return model;
        }
    }
}
