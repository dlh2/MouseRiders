using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.DTO
{
    public class MensajeDTO
    {
        //Atributo id
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        //Atributo Asunto
        [Display(Prompt = "Asunto", Description = "Asunto del mensaje", Name = "Asunto:")]
        [Required(ErrorMessage = "Debe existir un asunto")]
        //[StringLength(maximumLength: Globals.ASUNTO_MAX_LENGTH, ErrorMessage = "El asunto del mensaje no puede tener más de {0} caracteres")]
        public string Asunto { get; set; }

        //Atributo Asunto
        [Display(Prompt = "Destinatario", Description = "Destinatario", Name = "Destinatario:")]
        [Required(ErrorMessage = "Debe existir un destinatario")]
        //[StringLength(maximumLength: Globals.ASUNTO_MAX_LENGTH, ErrorMessage = "El asunto del mensaje no puede tener más de {0} caracteres")]
        public string Destinatario { get; set; }

        //Atributo Texto
        [Display(Prompt = "Texto", Description = "Texto del mensaje", Name = "Texto:")]
        [Required(ErrorMessage = "Debe existir un texto")]
        //[StringLength(maximumLength: Globals.TEXTO_MAX_LENGTH, ErrorMessage = "El texto del mensaje no puede tener más de {0} caracteres")]
        public string Texto { get; set; }

        //Atributo Adjunto
        [Display(Prompt = "Adjunto", Description = "Adjunto del mensaje", Name = "Adjunto:")]
        [Required(ErrorMessage = "Debe existir un adjunto")]
        //[StringLength(maximumLength: Globals.ADJUNTO_MAX_LENGTH, ErrorMessage = "El adjunto del mensaje no puede tener más de {0} caracteres")]
        public string Adjunto { get; set; }

        //Atributo Tipo
        [Display(Prompt = "Tipo", Description = "Tipo del mensaje", Name = "Tipo:")]
        [Required(ErrorMessage = "Debe existir un tipo")]
        //[StringLength(maximumLength: Globals.TIPO_MAX_LENGTH, ErrorMessage = "El tipo del mensaje no puede tener más de {0} caracteres")]
        public T_MensajeEnum Tipo { get; set; }

        //Atributo U_Recibido
        [ScaffoldColumn(false)]
        [Display(Prompt = "U_Recibido", Description = "U_Recibido", Name = "U_Recibido")]
        public IList<UsuarioDTO> U_Recibido { get; set; }

        //Atributo Notificaciones
        [ScaffoldColumn(false)]
        [Display(Prompt = "Notificaciones", Description = "Notificaciones", Name = "Notificaciones")]
        public ControladorNotificacionesDTO Notificaciones { get; set; }
    }
}
