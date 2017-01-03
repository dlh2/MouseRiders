using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers
{
    public class RecompensaController : BasicController
    {
        //
        // GET: /Recompensa/

        public ActionResult Index()
        {
            SessionInitialize();
            RecompensaCAD recompensaCAD = new RecompensaCAD(session);
            IList<RecompensaEN> recompensaEN = recompensaCAD.ReadAllDefault(0,10);
            SessionClose();
            return View(recompensaEN);
        }

        //
        // GET: /Recompensa/Details/5
        /*
        public ActionResult Details(string nombre)
        {
            SessionInitialize();
            RecompensaCAD recompensaCAD = new RecompensaCAD(session);
            IList<RecompensaEN> result = recompensaCAD.ReadFilter(nombre);
            SessionClose();
            return View(result);
        }*/

        //
        // GET: /Recompensa/Create

        public ActionResult Create(int id)
        {
            RecompensaEN recompensa = new RecompensaEN();
            recompensa.Id = id;
            return View(recompensa);
        }

        //
        // POST: /Recompensa/Create

        [HttpPost]
        public ActionResult Create(RecompensaEN recompensa)
        {
            try
            {
                RecompensaCAD cCAD = new RecompensaCAD();
                RecompensaCEN cen = new RecompensaCEN(cCAD);
                cen.CrearRecompensa(recompensa.Nombre, recompensa.Descripcion, recompensa.Puntuacion);
                return RedirectToAction("Details", new { id = recompensa.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Recompensa/Edit/5

        public ActionResult Edit(int id)
        {
            RecompensaCEN recompensaCEN = new RecompensaCEN();
            RecompensaEN r=recompensaCEN.ReadOID(id);
            return View(r);
        }

        //
        // POST: /Recompensa/Edit/5

        [HttpPost]
        public ActionResult Edit(RecompensaEN recompensa)
        {
            try
            {
                RecompensaCEN recompensaCEN = new RecompensaCEN();
                recompensaCEN.ModificarRecompensa(recompensa.Id,recompensa.Nombre, recompensa.Descripcion, recompensa.Puntuacion);
                return RedirectToAction("Index", new { id=recompensa.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Recompensa/Delete/5

        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                SessionInitialize();
                RecompensaCAD recompensaCAD = new RecompensaCAD(session);
                RecompensaCEN recompensaCEN = new RecompensaCEN(recompensaCAD);
                recompensaCEN.BorrarRecompensa(id);
                SessionClose();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Recompensa/Delete/5

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
