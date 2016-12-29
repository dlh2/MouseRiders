using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase ComentarioDTO
namespace MouseRidersGenNHibernate.DTO.MouseRiders
{
    public class ComentarioDTO
    {
        //Atributo id
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        //Atributo creador
        //[HiddenInput(DisplayValue = false)]
        [Display(Prompt = "Autor", Description = "Autor del comentario", Name = "Autor:")]
        [Required(ErrorMessage = "Debe existir un usuario")]
        [StringLength(maximumLength: Globals.USUARIO_MAX_LENGTH, ErrorMessage = "El nombre del usuario no puede tener más de {0} caracteres")]
        public string Creador { get; set; }
        

        //Atributo fecha
        //[HiddenInput(DisplayValue = false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Prompt = "Fecha", Description = "Fecha del comentario", Name = "Fecha:")]
        [Required(ErrorMessage = "Debe de indicar una fecha para el comentario")]
        public Nullable<DateTime> Fecha { get; set; }


        //Atributo contenido
        [Display(Prompt = "Comentario", Description = "Contenido del comentario", Name = "Contenido:")]
        [Required(ErrorMessage = "Un comentario, ¡necesita un comentario!")]
        [StringLength(maximumLength: Globals.COMENTARIO_MAX_LENGTH, ErrorMessage = "El comentario no puede tener más de {0} caracteres")]
        public string Contenido { get; set; }


        //Atributo valoracion
        [Display(Prompt = "Puntuación", Description = "Puntuación de la encuesta", Name = "Puntuación:")]
        [Range(Globals.PUNTUACION_MIN, Globals.PUNTUACION_MAX,
            ErrorMessage = "{0} debe estar entre {1} y {2}")]
        public int Valoracion { get; set; }

    }
}