using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase ControladorNotificacionesDTO
namespace MouseRidersWeb.DTO
{
    public class ControladorNotificacionesDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }


        //Relacion
        [ScaffoldColumn(false)]
        [Display(Prompt = "Notificaciones Enviadas", Description = "Notificaciones Enviadas", Name = "Notificaciones Enviadas")]
        public IList<MensajeDTO> enviaN { get; set; }

        //Relacion
        [Display(Prompt = "adjunto", Description = "adjunto", Name = "adjunto")]
        public  string adjunto { get; set; }

        //Relacion
        [Display(Prompt = "texto", Description = "texto", Name = "texto")]
        public string  texto { get; set; }

        //Relacion
        [Display(Prompt = "asunto", Description = "asunto", Name = "asunto")]
        public string asunto { get; set; }
    }
}