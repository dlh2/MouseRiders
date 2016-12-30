using MRModel.CAD;
using MRModel.CEN;
using MRModel.EN;
using MRWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRWeb.Controllers
{
    public class ControladorNotificacionesController : BasicController
    {
        // GET: ControladorNotificaciones
        public ActionResult Index()
        {
            ControladorNotificacionesCEN _ControladorNotificacionesCEN = new ControladorNotificacionesCEN();
            IList<ControladorNotificacionesEN> controladornotificacioness = _ControladorNotificacionesCEN.ReadAll(0, 10);
            return View(controladornotificacioness);
        }

        // GET: ControladorNotificaciones/Details/5
        public ActionResult Details(int id)
        {
            ControladorNotificacionesCEN _ControladorNotificacionesCAD = new ControladorNotificacionesCEN();
            ControladorNotificacionesEN controladornotificaciones = _ControladorNotificacionesCAD.ReadOID(id);
            return View(controladornotificaciones);
        }

        // GET: ControladorNotificaciones/Create
        public ActionResult Create(int id)
        {
            //En el ejemplo hay un int id.
            ControladorNotificacionesEN controladornotificaciones = new ControladorNotificacionesEN();
            controladornotificaciones.Id = id;
            return View(controladornotificaciones);
        }

        // POST: ControladorNotificaciones/Create
        [HttpPost]
        public ActionResult Create(ControladorNotificacionesEN controladornotificaciones)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                // TODO: Parece que aqui siempre hay que cambiar algo.
                ControladorNotificacionesCEN cen = new ControladorNotificacionesCEN();
                cen.CrearCNotificaciones();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ControladorNotificaciones/Edit/5
        public ActionResult Edit(int id)
        {
            ControladorNotificacionesCEN cen = new ControladorNotificacionesCEN();
            ControladorNotificacionesEN controladornotificaciones = cen.ReadOID(id);
            return View(controladornotificaciones);
        }

        // POST: ControladorNotificaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(ControladorNotificacionesEN controladornotificaciones)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                ControladorNotificacionesCEN cen = new ControladorNotificacionesCEN();
                cen.ModificarCNotificaciones(controladornotificaciones.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ControladorNotificaciones/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                //Como ya se sabe cual se elimina, y no dejamos si confirmamos o no, pues con un GET delete va que chuta.
                new ControladorNotificacionesCEN().BorrarCNotificaciones(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: ControladorNotificaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
