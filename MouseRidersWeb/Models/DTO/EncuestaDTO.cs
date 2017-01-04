using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase EncuestaDTO
namespace MouseRidersWeb.DTO
{
    public class EncuestaDTO
    {
        /**
         *	Atributo id
         */
        [ScaffoldColumn(false)]
        public int id { get; set; }




        /**
         *	Atributo titulo
         */
        [Display(Prompt = "Título", Description = "Título de la encuesta", Name = "TituloN ")]
        [Required(ErrorMessage = "Debe de indicar el título de la encuesta")]
        [StringLength(maximumLength: 200, ErrorMessage = "El título no puede tener más de 200 caracteres")]
        public string titulo { get; set; }
       

        /**
         *	Atributo tiene
         */

        [Display(Prompt = "Preguntas", Description = "Preguntas de la encuesta", Name = "PreguntasN ")]
        [Required(ErrorMessage = "Debe indicar las preguntas que pertenecen a la encuesta")]
        [DataType(DataType.Currency, ErrorMessage = "El dato introducido debe de ser una lista de preguntas")]
        public System.Collections.Generic.IList<MouseRidersWeb.DTO.PreguntaDTO> Tiene { get; set; }

        //private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PreguntaDTO> tiene;
    }
}