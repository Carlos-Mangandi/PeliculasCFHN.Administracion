using System.ComponentModel.DataAnnotations;

namespace Peliculas.AdministracionBlazor.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerido")]
        public string FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La nacionalidad es requerida")]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "La imagen es requerida")]
        public string Imagen { get; set; }
    }
}
