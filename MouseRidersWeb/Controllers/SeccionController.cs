using MRModel.CAD;
using MRModel.CEN;
using MRModel.EN;
using MRModel.Enumerated;
using MRWeb.Assembler;
using MRWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRWeb.Controllers
{
    public class SeccionController : BasicController
    {
        //
        // GET: /Seccion/

        public ActionResult Index()
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            IList<SeccionEN> result = cCAD.ReadAllDefault(0, 10);
            IList<SeccionDTO> resultfinal = new List<SeccionDTO>();
            foreach (SeccionEN entry in result)
                resultfinal.Add(new SeccionAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }



        public ActionResult Mostrar2(String nombre)
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            SeccionEN result = cCAD.ReadFilter(nombre);
            IList<ArticuloEN> resultfinal=result.Tiene;
            IList<ArticuloDTO> resultadofinal = new List<ArticuloDTO>();
            foreach (ArticuloEN entry in resultfinal)
                resultadofinal.Add(new ArticuloAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }
    
        //
        // GET: /Seccion/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            SeccionEN resultEN = cCAD.ReadOID(id);
            SeccionDTO result = new SeccionAssembler().ConvertConArticulo(resultEN);
            SessionClose();
            return View(result);
        }

        //

        //
        // GET: /Seccion/Create

        public ActionResult Create()
        {
            SeccionEN sec = new SeccionEN();
            return View(sec);
        }

        //
        // POST: /Seccion/Create

        [HttpPost]
        public ActionResult Create(SeccionEN sec)
        {
            try
            {
                SeccionCAD cCAD = new SeccionCAD();
                SeccionCEN cen = new SeccionCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                cen.CrearSeccion(sec.Nombre);

                return RedirectToAction("Details", new { id = sec.Seccion });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Seccion/Edit/5

        public ActionResult Edit(int id)
        {
            SeccionCAD cCAD = new SeccionCAD();
            SeccionEN result = cCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Seccion/Edit/5

        [HttpPost]
        public ActionResult Edit(SeccionEN sec)
        {
            try
            {
                SeccionCEN cen = new SeccionCEN();
                cen.ModificarSeccion(sec.Seccion,sec.Nombre);

                return RedirectToAction("Details", new { id = sec.Seccion });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Seccion/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            SeccionEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new SeccionCEN().BorrarSeccion(id);

            return View(result);
        }

        //
        // POST: /Seccion/Delete/5

        [HttpPost]
        public ActionResult Delete(SeccionEN sec)
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
