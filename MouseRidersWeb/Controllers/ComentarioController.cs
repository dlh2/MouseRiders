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
    public class ComentarioController : BasicController
    {
        //
        // GET: /Comentario/

        public ActionResult Index()
        {
            SessionInitialize();
            ComentarioCAD cCAD = new ComentarioCAD(session);
            IList<ComentarioEN> result = cCAD.ReadAllDefault(0, 10);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Comentario/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            ComentarioCAD cCAD = new ComentarioCAD(session);
            ComentarioEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            return View(result);
        }


        //
        // GET: /Comentario/Create

        public ActionResult Create()
        {
            ComentarioEN com = new ComentarioEN();
            return View(com);
        }

        //
        // POST: /Comentario/Create

        [HttpPost]
        public ActionResult Create(ComentarioEN com)
        {
            try
            {
                ComentarioCAD cCAD = new ComentarioCAD();
                ComentarioCEN cen = new ComentarioCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                cen.CrearComentario(com.Creador,p_fecha,com.Contenido,com.Valoracion);
                return RedirectToAction("Details", new { id = com.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Comentario/Edit/5

        public ActionResult Edit(int id)
        {
            ComentarioCAD cCAD = new ComentarioCAD();
            ComentarioEN result = cCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Comentario/Edit/5

        [HttpPost]
        public ActionResult Edit(ComentarioEN com)
        {
            try
            {
                ComentarioCEN cen = new ComentarioCEN();
                cen.ModificarComentario(com.Id,com.Creador, com.Fecha, com.Contenido, com.Valoracion);

                return RedirectToAction("Details", new { id = com.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Comentario/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            ComentarioCAD cCAD = new ComentarioCAD(session);
            ComentarioEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new ComentarioCEN().BorrarComentario(id);

            return View(result);
        }

        //
        // POST: /Comentario/Delete/5

        [HttpPost]
        public ActionResult Delete(ComentarioEN com)
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
