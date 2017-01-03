using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers.Especiales
{
    public class ContactoController : BasicController
    {
        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Contacto/Contenido

        public ActionResult Contenido()
        {
            return View();
        }

        //
        // GET: /Contacto/Admin

        public ActionResult Admin()
        {
            return View();
        }

        //
        // GET: /Contacto/Redactor

        public ActionResult Redactor()
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Contacto/Puesto

        public ActionResult Puesto()
        {
            return View();
        }



        //
        // POST: /Contacto/Contenido

        [HttpPost]
        public ActionResult Contenido(string Asunto, string Texto, string Adjunto )
        {
            try
            {
                MensajeEN mensaje = new MensajeEN();
                mensaje.Tipo=T_MensajeEnum.sugerencia;
                mensaje.Asunto = Asunto;
                mensaje.Texto = Texto;
                mensaje.Adjunto = Adjunto;
                return RedirectToAction("Create", "Mensaje", mensaje);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Contacto/Admin

        [HttpPost]
        public ActionResult Admin(string Asunto, string Texto, string Adjunto)
        {
            try
            {
                MensajeEN mensaje = new MensajeEN();
                mensaje.Tipo = T_MensajeEnum.admin;
                mensaje.Asunto = Asunto;
                mensaje.Texto = Texto;
                mensaje.Adjunto = Adjunto;
                return RedirectToAction("Create", "Mensaje", mensaje);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Contacto/Redactor

        [HttpPost]
        public ActionResult Redactor(string Asunto, string Texto, string Adjunto)
        {
            try
            {
                MensajeEN mensaje = new MensajeEN();
                mensaje.Tipo = T_MensajeEnum.redactor;
                mensaje.Asunto = Asunto;
                mensaje.Texto = Texto;
                mensaje.Adjunto = Adjunto;
                return RedirectToAction("Create", "Mensaje", mensaje);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Contacto/Puesto

        [HttpPost]
        public ActionResult Puesto(string Asunto, string Texto, string Adjunto)
        {
            try
            {
                MensajeEN mensaje = new MensajeEN();
                mensaje.Tipo = T_MensajeEnum.solicitud;
                mensaje.Asunto = Asunto;
                mensaje.Texto = Texto;
                mensaje.Adjunto = Adjunto;
                return RedirectToAction("Create", "Mensaje", mensaje);
            }
            catch
            {
                return View();
            }
        }
    }
}
