using MRWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Definición clase HiloDTO
namespace MRWeb.DTO
{
    public class HiloDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }




        /**
         *	Atributo Titulo
         */
        [Display(Prompt = "Titulo", Description = "Titulo del articulo", Name = "Titulo:")]
        [Required(ErrorMessage = "Debe tener un titulo")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "El Titulo no puede tener más de {0} caracteres")]
        public string Titulo { get; set; }
        

        /**
        *	Atributo fecha
        */
        [Display(Prompt = "Fecha", Description = "Fecha del comentario", Name = "Fecha:")]
        [Required(ErrorMessage = "Debe de indicar una fecha para el comentario")]
        public Nullable<DateTime> Fecha { get; set; }


        /**
         *	Atributo Creador
         */
        [Display(Prompt = "Creador", Description = "Creador del hilo", Name = "Creador:")]
        [Required(ErrorMessage = "Debe tener un creador")]
        [StringLength(maximumLength: Globals.CREADOR_MAX_LENGTH, ErrorMessage = "El nombre del creador no puede tener más de {0} caracteres")]
        public string Creador { get; set; }

        /**
        *	Atributo NumComentarios
        */
        [Display(Prompt = "Numero de comentarios", Description = "Numero de comentarios del hilo", Name = "Numero de comentarios:")]
        //[StringLength(maximumLength: Globals.CONTENIDO_MAX_LENGTH, ErrorMessage = "El contenido descargable no puede tener más de {0} caracteres")]
        public int NumComentarios { get; set; }


       
        //Relaciones

    }
}