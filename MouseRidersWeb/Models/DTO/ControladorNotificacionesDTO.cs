using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
    }
}