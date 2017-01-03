using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Definición clase PreguntaDTO
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
    public class PreguntaDTO
    {
        /**
         *	Atributo id
         */
        [ScaffoldColumn(false)]
        public int id { get; set; }



        /**
         *	Atributo pregunta
         */

        [Display(Prompt = "Pregunta", Description = "Cuerpo de la pregunta", Name = "PreguntaN ")]
        [Required(ErrorMessage = "Debe indicar el texto de la pregunta")]
        [StringLength(maximumLength: 200, ErrorMessage = "La pregunta no puede tener más de 200 caracteres")]
        public string Pregunta { get; set; }

        /**
         *	Atributo tipo
         */
        /*
        [Display(Prompt = "Tipo", Description = "Tipo de pregunta", Name = "TipoN ")]
        [Required(ErrorMessage = "Debe indicar de que tipo es la pregunta")]
        [DataType(DataType.Currency, ErrorMessage = "La pregunta ha de ser de un tipo concreto")]
        public MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo { get; set; }
        */
        private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum Tipo { get; set; }

        /**
         *	Atributo pertenece
         */
        [Display(Prompt = "Encuesta", Description = "Encuesta a la que pertenece la pregunta", Name = "EncuestaN ")]
        [Required(ErrorMessage = "Debe indicar la encuesta en la que aparece esta pregunta")]
        [DataType(DataType.Currency, ErrorMessage = "El dato introducido debe de ser una encuesta")]
        public MouseRidersGenNHibernate.EN.MouseRiders.EncuestaDTO Pertenece { get; set; }


        /**
         *	Atributo tiene
         */
        [Display(Prompt = "Respuestas", Description = "Respuestas de la pregunta", Name = "RespuestasN ")]
        [Required(ErrorMessage = "Debe indicar las respuestas posibles de la pregunta")]
        [DataType(DataType.Currency, ErrorMessage = "El dato introducido debe de ser una lista de respuestas")]
        public System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN> Tiene { get; set; }

    }
}
        //private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN> tiene;
