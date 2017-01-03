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
    public class RespuestaController : BasicController
    {
        //
        // GET: /Respuesta/

        public ActionResult Index()
        {
            SessionInitialize();
            RespuestaCAD cCAD = new RespuestaCAD(session);
            IList<RespuestaEN> result = cCAD.ReadAllDefault(0, 10);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Respuesta/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            RespuestaCAD cCAD = new RespuestaCAD(session);
            RespuestaEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Respuesta/Create

        public ActionResult Create()
        {
            RespuestaEN usu = new RespuestaEN();
            return View(usu);
        }

        //
        // POST: /Respuesta/Create

        [HttpPost]
        public ActionResult Create(RespuestaEN respu)
        {
            try
            {
                RespuestaCAD cCAD = new RespuestaCAD();
                RespuestaCEN cen = new RespuestaCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                cen.CrearRespuesta(respu.Respuesta, respu.Tipo, respu.Pertenece.Id, respu.Contador, respu.Frecuencia);

                return RedirectToAction("Details", new { id = respu.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Respuesta/Edit/5

        public ActionResult Edit(int id)
        {
            RespuestaCAD cCAD = new RespuestaCAD();
            RespuestaEN result = cCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Respuesta/Edit/5

        [HttpPost]
        public ActionResult Edit(RespuestaEN respu)
        {
            try
            {
                RespuestaCEN cen = new RespuestaCEN();
                cen.ModificarRespuesta(respu.Id, respu.Respuesta, respu.Tipo, respu.Contador, respu.Frecuencia);
                return RedirectToAction("Details", new { id = respu.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Respuesta/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            RespuestaCAD cCAD = new RespuestaCAD(session);
            RespuestaEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new RespuestaCEN().BorrarRespuesta(id);

            return View(result);
        }

        //
        // POST: /Respuesta/Delete/5

        [HttpPost]
        public ActionResult Delete(RespuestaEN respu)
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
