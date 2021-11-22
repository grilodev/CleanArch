using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly IAnuncioService _anuncioService;
        
        public AnuncioController(IAnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _anuncioService.GetAnuncios();
            return View(result);
        }

        [HttpGet()]
        public IActionResult Create()
        {
            ViewBag.Marcas = _anuncioService.GetMarcas();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Marca","Modelo","Versao","Ano","Quilometragem","Observacao")]AnuncioViewModel anuncio)
        {
            if (ModelState.IsValid)
            {
                _anuncioService.Add(anuncio);
                return RedirectToAction(nameof(Index));
            }

            return View(anuncio);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var anuncio = await _anuncioService.GetById(id);

            if (anuncio == null)
                return NotFound();

            ViewBag.Marcas = _anuncioService.GetMarcas();

            return View(anuncio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Marca", "Modelo", "Versao", "Ano", "Quilometragem", "Observacao", "ID")] AnuncioViewModel anuncio)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _anuncioService.Update(anuncio);
                }
                catch (Exception)
                {
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(anuncio);
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var anuncio = await _anuncioService.GetById(id);

            if (anuncio == null)
                return NotFound();

            return View(anuncio);
        }

        [HttpPost(), ActionName("Delete")]
        public IActionResult DeleteConfirmed(AnuncioViewModel anuncio)
        {
            _anuncioService.Remove(anuncio);
            return RedirectToAction("Index");
        }
    }
}
