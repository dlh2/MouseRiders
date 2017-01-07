using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Assembler;
using MouseRidersWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers.Especiales
{
    public class NoticiasController : BasicController
    {

        //
        // Ajax GET: /Noticia/

        public ActionResult Index(String minimo)
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            SeccionEN resultEN = cCAD.ReadFilter("NoticiasPC");
            int a = 0;
            if (minimo == null)
            {
                a = 3;
            }
            else
            {
                a = Int32.Parse(minimo) * 10;
            }
            SeccionDTO result = new SeccionAssembler().ConvertNoticiaConArticulo(resultEN, a, 10);
            SessionClose();
            if (Request.IsAjaxRequest())
            {
                if (result != null)
                {
                    return PartialView("_Articulo", result);
                }
                return PartialView("_Articulo", new SeccionDTO());
            }
            return View(result);
        }

        //
        // GET: /Noticias/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Noticias/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Noticias/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Noticias/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Noticias/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Noticias/Delete/5

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
