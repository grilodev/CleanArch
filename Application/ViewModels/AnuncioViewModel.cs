using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class AnuncioViewModel
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "A marca é obrigatória")]
        [DisplayName("Marca")]
        public string Marca { get; set; }
        
        [Required(ErrorMessage = "O modelo é obrigatório")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "A versão é obrigatória")]
        [DisplayName("Versão")]
        public string Versao { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório")]
        [DisplayName("Ano")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "A quilometragem é obrigatória")]
        [DisplayName("Quilometragem")]
        public int Quilometragem { get; set; }

        [Required(ErrorMessage = "A observação é obrigatória")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

    }
}
