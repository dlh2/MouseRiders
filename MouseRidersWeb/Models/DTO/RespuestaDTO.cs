using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase RespuestaDTO
namespace MouseRidersWeb.DTO
{
    public class RespuestaDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }


        /**
         *	Atributo Respuesta
         */
        [Display(Prompt = "Respuesta", Description = "Respuesta", Name = "Respuesta:")]
        [Required(ErrorMessage = "Debe tener ua Respuesta")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "La Respuesta no puede tener más de {0} caracteres")]
        public string Respuesta { get; set; }


        //Atributo Tipo
        [Display(Prompt = "Tipo", Description = "Tipo del mensaje", Name = "Tipo:")]
        [Required(ErrorMessage = "Debe existir un tipo")]
        //[StringLength(maximumLength: Globals.TIPO_MAX_LENGTH, ErrorMessage = "El tipo del mensaje no puede tener más de {0} caracteres")]
        public T_PreguntaEnum Tipo { get; set; }


        /**
        *	Atributo contador
        */
        [Display(Prompt = "Contador", Description = "Contador", Name = "Contador:")]
        //[StringLength(maximumLength: Globals.CONTENIDO_MAX_LENGTH, ErrorMessage = "El contenido descargable no puede tener más de {0} caracteres")]
        public int Contador { get; set; }

        /**
       *	Atributo Frecuencia
       */
        [Display(Prompt = "Frecuencia", Description = "Frecuencia", Name = "Frecuencia:")]
        //[StringLength(maximumLength: Globals.CONTENIDO_MAX_LENGTH, ErrorMessage = "El contenido descargable no puede tener más de {0} caracteres")]
        public float Frecuencia { get; set; }

        //Relaciones

    }
}