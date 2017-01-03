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
    public class HiloController : BasicController
    {
        //
        // GET: /Hilo/

        public ActionResult Index()
        {
            SessionInitialize();
            HiloCAD cCAD = new HiloCAD(session);
            IList<HiloEN> result = cCAD.ReadAllDefault(0, 10);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Hilo/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            HiloCAD cCAD = new HiloCAD(session);
            HiloEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            return View(result);
        }


        //
        // GET: /Hilo/Create

        public ActionResult Create()
        {
            HiloEN hilo = new HiloEN();
            return View(hilo);
        }

        //
        // POST: /Hilo/Create

        [HttpPost]
        public ActionResult Create(HiloEN hilo)
        {
            try
            {
                HiloCAD cCAD = new HiloCAD();
                HiloCEN cen = new HiloCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                cen.CrearHilo(hilo.Creador,p_fecha,hilo.NumComentarios,hilo.Titulo);
                return RedirectToAction("Details", new { id = hilo.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Hilo/Edit/5

        public ActionResult Edit(int id)
        {
            HiloCAD cCAD = new HiloCAD();
            HiloEN result = cCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Hilo/Edit/5

        [HttpPost]
        public ActionResult Edit(HiloEN hilo)
        {
            try
            {
                HiloCEN cen = new HiloCEN();
                cen.ModificarHilo(hilo.Id,hilo.Creador, hilo.Fecha, hilo.NumComentarios, hilo.Titulo);

                return RedirectToAction("Details", new { id = hilo.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Hilo/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            HiloCAD cCAD = new HiloCAD(session);
            HiloEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new HiloCEN().BorrarHilo(id);

            return View(result);
        }

        //
        // POST: /Hilo/Delete/5

        [HttpPost]
        public ActionResult Delete(HiloEN hilo)
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