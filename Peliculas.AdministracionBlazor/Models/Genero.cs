﻿using System.ComponentModel.DataAnnotations;

namespace Peliculas.AdministracionBlazor.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
    }
}
