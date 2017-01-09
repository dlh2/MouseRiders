using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.CP.MouseRiders;
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

        public ActionResult Index()
        {
            SessionInitialize();
            ControladorNotificacionesCAD cCAD = new ControladorNotificacionesCAD(session);
            IList<ControladorNotificacionesEN> resultEN = cCAD.ReadAllDefault(0, 10);
            IList<ControladorNotificacionesDTO> result = new List<ControladorNotificacionesDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                result.Add(new ControladorNotificacionesAssembler().Convert(resultEN[i]));
            }
            SessionClose();
            return View(result);
        }





        public ActionResult Notificar()
        {
            ControladorNotificacionesEN controladornotificaciones = new ControladorNotificacionesEN();
            ControladorNotificacionesDTO result = new ControladorNotificacionesAssembler().Convert(controladornotificaciones);
            return View(result);
        }

        // POST: ControladorNotificaciones/Create
        [HttpPost]
        public ActionResult Notificar(ControladorNotificacionesDTO controladornotificaciones)
        {
            try
            {
                ControladorNotificacionesCP controlCEN = new ControladorNotificacionesCP();
                controlCEN.EnviarNotificaciones(null, null, "hola a todos", controladornotificaciones.texto, controladornotificaciones.adjunto);
                return RedirectToAction("Index", new { id = controladornotificaciones.Id });
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Details(int id)
        {
            SessionInitialize();
            ControladorNotificacionesCAD cCAD = new ControladorNotificacionesCAD(session);
            ControladorNotificacionesEN result = cCAD.ReadOIDDefault(id);
            ControladorNotificacionesDTO resultfinal = new ControladorNotificacionesAssembler().Convert(result);
            SessionClose();
            return View(resultfinal);
        }


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
