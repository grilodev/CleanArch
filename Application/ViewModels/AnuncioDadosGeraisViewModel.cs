using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public class AnuncioDadosGeraisViewModel
    {
        public List<SelectListItem> Marcas { get; set; }
        public List<SelectListItem> Modelos { get; set; }
        public List<SelectListItem> Versoes { get; set; }

        public AnuncioDadosGeraisViewModel()
        {
            Marcas = new List<SelectListItem>();
            Modelos = new List<SelectListItem>();
            Versoes = new List<SelectListItem>();
        }
    }
}
