using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Definición clase BloqueoDTO
namespace MouseRidersWeb.DTO
{
    public class BloqueoDTO
    {
        /**
         *	Atributo id
         */
        [ScaffoldColumn(false)]
        public int Id { get; set; }


        /**
        *	Atributo FechaInicio
        */
        [Display(Prompt = "Fecha Inicio", Description = "Fecha Inicio del bloqueo", Name = "Fecha Inicio:")]
        [Required(ErrorMessage = "Debe de indicar una fecha inicio para el comentario")]
        public Nullable<DateTime> FechaInicio { get; set; }

        /**
        *	Atributo FechaFin
        */
        [Display(Prompt = "Fecha Fin", Description = "Fecha Fin del comentario", Name = "Fecha Fin:")]
        [Required(ErrorMessage = "Debe de indicar una fecha fin para el comentario")]
        public Nullable<DateTime> FechaFin { get; set; }

        //Atributo Contiene
        [ScaffoldColumn(false)]
        [Display(Prompt = "Denuncias", Description = "Denuncias", Name = "Denuncias")]
        public IList<DenunciaDTO> Contiene { get; set; }

    }
}