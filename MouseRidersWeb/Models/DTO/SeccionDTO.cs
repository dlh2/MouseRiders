using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Definición clase SeccionDTO
namespace MouseRidersWeb.DTO
{
    public class SeccionDTO
    {

        //Atributo Seccion (ID)
        [ScaffoldColumn(false)]
        [Display(Prompt = "Seccion", Description = "Seccion", Name = "Seccion:")]
        //[StringLength(maximumLength: Globals.CONTENIDO_MAX_LENGTH, ErrorMessage = "El contenido descargable no puede tener más de {0} caracteres")]
        public int Seccion { get; set; }
        
        //Atributo Nombre
        [Display(Prompt = "Nombre", Description = "Nombre de la seccion", Name = "Nombre:")]
        [Required(ErrorMessage = "Debe tener un Nombre")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "El Nombre no puede tener más de {0} caracteres")]
        public string Nombre { get; set; }

        
        //Relaciones


        //Atributo Tiene
        [ScaffoldColumn(false)]
        //[Display(Prompt = "Comentarios", Description = "Comentarios", Name = "Comentarios")]
        public IList<ArticuloDTO> Tiene { get; set; }

    }
}