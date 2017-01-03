using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers
{
    public class BloqueoController : BasicController
    {
        // GET: Bloqueo
        public ActionResult Index()
        {
            BloqueoCEN _BloqueoCEN = new BloqueoCEN();
            IList<BloqueoEN> bloqueos = _BloqueoCEN.ReadAll(0, 10);
            return View(bloqueos);
        }

        // GET: Bloqueo/Details/5
        public ActionResult Details(int id)
        {
            BloqueoCEN _BloqueoCAD = new BloqueoCEN();
            BloqueoEN bloqueo = _BloqueoCAD.ReadOID(id);
            return View(bloqueo);
        }

        // GET: Bloqueo/Create
        public ActionResult Create(int id)
        {
            //En el ejemplo hay un int id.
            BloqueoEN bloqueo = new BloqueoEN();
            bloqueo.Id = id;
            return View(bloqueo);
        }

        // POST: Bloqueo/Create
        [HttpPost]
        public ActionResult Create(BloqueoEN bloqueo)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                // TODO: Parece que aqui siempre hay que cambiar algo.
                BloqueoCEN cen = new BloqueoCEN();
                IList<int> aux = new List<int>();
                for (int i = 0; i < bloqueo.Contiene.Count; i++)
                    aux.Add(bloqueo.Contiene[i].Id);
                cen.CrearBloqueo(aux,bloqueo.Pertenece.Id, bloqueo.FechaInicio, bloqueo.FechaFin);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bloqueo/Edit/5
        public ActionResult Edit(int id)
        {
            BloqueoCEN cen = new BloqueoCEN();
            BloqueoEN bloqueo = cen.ReadOID(id);
            return View(bloqueo);
        }

        // POST: Bloqueo/Edit/5
        [HttpPost]
        public ActionResult Edit(BloqueoEN bloqueo)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                BloqueoCEN cen = new BloqueoCEN();
                cen.ModificarBloqueo(bloqueo.Id, bloqueo.FechaInicio,bloqueo.FechaFin);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bloqueo/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                //Como ya se sabe cual se elimina, y no dejamos si confirmamos o no, pues con un GET delete va que chuta.
                new BloqueoCEN().BorrarBloqueo(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Bloqueo/Delete/5
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
