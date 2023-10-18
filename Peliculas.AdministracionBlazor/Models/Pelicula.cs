using System.ComponentModel.DataAnnotations;

namespace Peliculas.AdministracionBlazor.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Genero es obligatorio")]
        public int IdGenero { get; set; }

        [Required(ErrorMessage = "Director es obligatorio")]
        public int IdDirector { get; set; }

        [Required(ErrorMessage = "Título es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Fecha de Estreno es obligatorio")]
        public string FechaEstreno { get; set; }

        [Required(ErrorMessage = "Actores es obligatorio")]
        public string Actores { get; set; }

        [Required(ErrorMessage = "Descripcion es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Imagen es obligatorio")]
        public string Imagen { get; set; }

        public Genero Genero { get; set; }

        public Director Director { get; set; }
    }
}
