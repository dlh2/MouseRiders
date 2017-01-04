using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase DenunciaDTO
namespace MouseRidersWeb.DTO
{
    public class DenunciaDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }


        /**
        *	Atributo fecha
        */
        [Display(Prompt = "Fecha", Description = "Fecha de la denuncia", Name = "Fecha:")]
        [Required(ErrorMessage = "Debe de indicar una fecha para la denuncia")]
        public Nullable<DateTime> Fecha { get; set; }


        /**
        *	Atributo Motivo
        */
        [Display(Prompt = "Motivo", Description = "Motivo", Name = "Motivo:")]
        [Required(ErrorMessage = "Debe tener un motivo")]
        [StringLength(maximumLength: Globals.DESCRIPCION_MAX_LENGTH, ErrorMessage = "El motivo no puede tener más de {0} caracteres")]
        public string Motivo { get; set; }
              

        //Relaciones

    }
}