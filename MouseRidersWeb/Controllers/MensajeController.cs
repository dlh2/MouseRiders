using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Assembler;
using MouseRidersWeb.Controllers;
using MouseRidersWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers
{
    public class MensajeController : BasicController
    {
       // GET: Mensaje/Create
        public ActionResult Create(int id)
        {
            //En el ejemplo hay un int id.
            MensajeEN mensaje = new MensajeEN();
            MensajeDTO result = new MensajeAssembler().Convert(mensaje);
            return View(result);
        }

        // POST: Mensaje/Create
        [HttpPost]
        public ActionResult Create(MensajeEN mensaje)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                // TODO: Parece que aqui siempre hay que cambiar algo.
                MensajeCEN cen = new MensajeCEN();
                IList<int> aux = new List<int>();
                for (int i = 0; i < mensaje.Es_recibido.Count; i++)
                    aux.Add(mensaje.Es_recibido[i].Id);
                cen.CrearMensaje(mensaje.Asunto, mensaje.Texto, mensaje.Adjunto, mensaje.Tipo, mensaje.Es_enviado.Id, aux);
                return RedirectToAction("Details", new { id = mensaje.Id });
            }
            catch
            {
                return View();
            }
        }
    }
}
