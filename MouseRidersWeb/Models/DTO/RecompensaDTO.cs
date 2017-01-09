using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase RecompensaDTO
namespace MouseRidersWeb.DTO
{
    public class RecompensaDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }
       
        //Atributo Nombre
        [Display(Prompt = "Nombre", Description = "Nombre de la recompensa", Name = "Nombre:")]
        [Required(ErrorMessage = "Debe tener un autor")]
        [StringLength(maximumLength: Globals.USUARIO_MAX_LENGTH, ErrorMessage = "El nombre de la recompensa no puede tener más de {0} caracteres")]
        public string Nombre { get; set; }

        //Atributo Puntuacion
        [Display(Prompt = "Puntuacion", Description = "Puntuacion de la recompensa", Name = "Puntuacion:")]
        [Required(ErrorMessage = "Debe existir un puntuacion")]
        [StringLength(maximumLength: Globals.PUNTUACION_MAX_LENGTH, ErrorMessage = "La puntuacion de la recompensa no puede tener más de {0} caracteres")]
        [Range(Globals.PUNTUACION_MIN, Globals.PUNTUACION_MAX,
           ErrorMessage = "{0} debe estar entre {1} y {2}")]
        public int Puntuacion { get; set; }

        //Atributo Descripcion
        [Display(Prompt = "Descripcion", Description = "Descripcion de la recompensa", Name = "Descripcion:")]
        [Required(ErrorMessage = "Debe tener una Descripcion")]
        [StringLength(maximumLength: Globals.DESCRIPCION_MAX_LENGTH, ErrorMessage = "La Descripcion no puede tener más de {0} caracteres")]
        public string Descripcion { get; set; }

        //Atributo Usuario
        [ScaffoldColumn(false)]
        [Display(Prompt = "Usuarios", Description = "Usuarios", Name = "Usuarios")]
        public IList<UsuarioDTO> Obtiene { get; set; }
    }
}