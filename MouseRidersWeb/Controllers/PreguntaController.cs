using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Assembler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MouseRidersWeb.DTO;

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
            IList<PreguntaDTO> resultfinal = new List<PreguntaDTO>();
            foreach (PreguntaEN entry in result)
                resultfinal.Add(new PreguntaAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }

        // GET: /Pregunta/

        public ActionResult Chart(int id)
        {
            SessionInitialize();
            PreguntaCAD cCAD = new PreguntaCAD(session);
            PreguntaEN result = cCAD.ReadOIDDefault(id);
            PreguntaDTO resultfinal = new PreguntaDTO();
            resultfinal = new PreguntaAssembler().ConvertConRespuesta(result);
            SessionClose();
            return View(resultfinal);
        }

       
        //
        // GET: /Pregunta/Edit/5

        public ActionResult Edit(int id)
        {
            PreguntaCAD cCAD = new PreguntaCAD();
            PreguntaEN result = cCAD.ReadOIDDefault(id);
            PreguntaDTO resultfinal = new PreguntaAssembler().Convert(result);
            return View(resultfinal);
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
            PreguntaDTO resultfinal = new PreguntaAssembler().Convert(result);
            SessionClose();

            return View(resultfinal);
        }

        //
        // POST: /Pregunta/Delete/5

        [HttpPost]
        public ActionResult Delete(PreguntaEN pregu)
        {
            try
            {
                
                new PreguntaCEN().BorrarPregunta(pregu.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
