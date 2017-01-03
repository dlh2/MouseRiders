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
    public class ControladorNotificacionesController : BasicController
    {
        

        // GET: ControladorNotificaciones/Create
        public ActionResult Create(int id)
        {
            ControladorNotificacionesEN controladornotificaciones = new ControladorNotificacionesEN();
            ControladorNotificacionesDTO result = new ControladorNotificacionesAssembler().Convert(controladornotificaciones);
            return View(result);
        }

        // POST: ControladorNotificaciones/Create
        [HttpPost]
        public ActionResult Create(ControladorNotificacionesEN controladornotificaciones)
        {
            try
            {
                ControladorNotificacionesCEN cen = new ControladorNotificacionesCEN();
                cen.CrearCNotificaciones();
                return RedirectToAction("Details", new { id = controladornotificaciones.Id });
            }
            catch
            {
                return View();
            }
        }
    }
}
