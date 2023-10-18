using System.ComponentModel.DataAnnotations;

namespace Peliculas.AdministracionBlazor.Models
{
    public class UsuarioEdit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Rol es obligatorio")]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "El Estatus es obligatorio")]
        public int Estatus { get; set; }
    }
}
