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
    public class PreguntaController : BasicController
    {
        //
        // GET: /Pregunta/

        public ActionResult Index()
        {
            SessionInitialize();
            PreguntaCAD cCAD = new PreguntaCAD(session);
            IList<PreguntaEN> result = cCAD.ReadAllDefault(0, 999);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Pregunta/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            PreguntaCAD cCAD = new PreguntaCAD(session);
            PreguntaEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Pregunta/Create

        public ActionResult Create()
        {
            PreguntaEN usu = new PreguntaEN();
            return View(usu);
        }

        //
        // POST: /Pregunta/Create

        [HttpPost]
        public ActionResult Create(PreguntaEN preg)
        {
            try
            {
                PreguntaCAD cCAD = new PreguntaCAD();
                PreguntaCEN cen = new PreguntaCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                cen.CrearPregunta(preg.Pregunta, preg.Tipo, preg.Pertenece.Id);

                return RedirectToAction("Details", new { id = preg.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pregunta/Edit/5

        public ActionResult Edit(int id)
        {
            PreguntaCAD cCAD = new PreguntaCAD();
            PreguntaEN result = cCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Pregunta/Edit/5

        [HttpPost]
        public ActionResult Edit(PreguntaEN preg)
        {
            try
            {
                PreguntaCEN cen = new PreguntaCEN();
                cen.ModificarPregunta(preg.Id, preg.Pregunta, preg.Tipo);

                return RedirectToAction("Details", new { id = preg.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pregunta/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            PreguntaCAD cCAD = new PreguntaCAD(session);
            PreguntaEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new PreguntaCEN().BorrarPregunta(id);

            return View(result);
        }

        //
        // POST: /Pregunta/Delete/5

        [HttpPost]
        public ActionResult Delete(PreguntaEN pregu)
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
