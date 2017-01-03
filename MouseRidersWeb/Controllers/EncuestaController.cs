using MouseRidersWeb.Assembler;
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
    public class EncuestaController : BasicController
    {
        //
        // GET: /Encuesta/

        public ActionResult Index()
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            IList<EncuestaEN> encuestaEN = eCAD.ReadAllDefault(0, 999);
            SessionClose();
            return View(encuestaEN);
        }
        
        //
        // GET: /Encuesta/Modelo/

        public ActionResult Modelo()
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            IList<EncuestaEN> encuestaEN = eCAD.ReadAllDefault(0, 999);
            EncuestaAssembler enc = new EncuestaAssembler();
            IList<EncuestaDTO> lista = new List<EncuestaDTO>();
            for (int i = 0; i < encuestaEN.Count; i++)
            {
                lista.Add(enc.ConvertConPreguntaYRespuesta(encuestaEN[i]));
            }
            SessionClose();
            return View(lista);
        }


        //
        // GET: /Encuesta/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            EncuestaEN encuesta_EN = eCAD.ReadOID(id);
            SessionClose();
            return View(encuesta_EN);
        }

        //
        // GET: /Encuesta/Create

        public ActionResult Create()
        {
            EncuestaEN enc = new EncuestaEN();
            return View(enc);
        }

        //
        // POST: /Encuesta/Create
        
        [HttpPost]
        public ActionResult Create(EncuestaEN enc)
        {
            try
            {
                EncuestaCAD eCAD = new EncuestaCAD();
                EncuestaCEN ecen = new EncuestaCEN(eCAD);
                DateTime p_fecha = DateTime.Now;
                ecen.CrearEncuesta(enc.Titulo, enc.Descripcion);
                return(RedirectToAction("Details", new { id = enc.Id }));
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Encuesta/Edit/5

        public ActionResult Edit(int id)
        {
            EncuestaCAD eCAD = new EncuestaCAD();
            EncuestaEN result = eCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Encuesta/Edit/5

        [HttpPost]
        public ActionResult Edit(EncuestaEN enc)
        {
            try
            {
                EncuestaCEN cen = new EncuestaCEN();
                cen.ModificarEncuesta(enc.Id, enc.Titulo, enc.Descripcion);

                return RedirectToAction("Details", new { id = enc.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Encuesta/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            EncuestaCAD cCAD = new EncuestaCAD(session);
            EncuestaEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new EncuestaCEN().BorrarEncuesta(id);

            return View(result);
        }

        //
        // POST: /Encuesta/Delete/5

        [HttpPost]
        public ActionResult Delete(EncuestaEN enc)
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
