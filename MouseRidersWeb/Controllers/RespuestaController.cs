using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Assembler;
using MouseRidersWeb.DTO;
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
            IList<RespuestaEN> result = cCAD.ReadAllDefault(0, 100);
            IList<RespuestaDTO> resultfinal = new List<RespuestaDTO>();
            foreach (RespuestaEN entry in result)
                resultfinal.Add(new RespuestaAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }
        //
        // GET: /Respuesta/Edit/5

        public ActionResult Edit(int id)
        {
            RespuestaCAD cCAD = new RespuestaCAD();
            RespuestaEN result = cCAD.ReadOIDDefault(id);
            RespuestaDTO resultfinal = new RespuestaAssembler().Convert(result);
            return View(resultfinal);
        }

        //
        // POST: /Respuesta/Edit/5

        [HttpPost]
        public ActionResult Edit(RespuestaEN Respuesta)
        {
            try
            {
                RespuestaCEN RespuestaCEN = new RespuestaCEN();
                RespuestaCEN.ModificarRespuesta(Respuesta.Id, Respuesta.Respuesta, Respuesta.Tipo, Respuesta.Contador,Respuesta.Frecuencia);
                return RedirectToAction("Index", new { id = Respuesta.Id });
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
            try
            {
                // TODO: Add delete logic here
                SessionInitialize();
                RespuestaCAD cCAD = new RespuestaCAD(session);
                RespuestaEN result = cCAD.ReadOIDDefault(id);
                RespuestaDTO resultfinal = new RespuestaAssembler().Convert(result);
                SessionClose();

                return View(resultfinal);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Respuesta/Delete/5

        [HttpPost]
        public ActionResult Delete(RespuestaEN resp)
        {
            try
            {
                new RespuestaCEN().BorrarRespuesta(resp.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
