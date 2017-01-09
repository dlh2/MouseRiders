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

namespace MouseRidersWeb.Controllers
{
    public class SeccionController : BasicController
    {

        //
        // Ajax GET: /Seccion/ La id es la id seccion

        public ActionResult Index(String minimo, Nullable<int> id)
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            IList<SeccionEN> resultEN = cCAD.ReadAllDefault(0, 10);
            int a = 0;
            if (id != null)
            {
                if (minimo == null)
                {
                    a =  3;
                }
                else
                {
                    a = Int32.Parse(minimo) * 10;
                }
            }
            IList<SeccionDTO> result = new List<SeccionDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                if (id == null)
                {
                    result.Add(new SeccionAssembler().ConvertConArticuloNum(resultEN[i], a, 3));
                }
                else
                {
                    if (resultEN[i].Seccion == id || id ==0)
                    {
                        result.Add(new SeccionAssembler().ConvertConArticuloNum(resultEN[i], a, 10));
                    }
                }
            }
            SessionClose();
            if (Request.IsAjaxRequest())
            {
                if (result.Count != 0)
                {
                    return PartialView("_Articulo", result);
                }
                return PartialView("_Articulo", new List<SeccionDTO>());
            }
            return View(result);
        }

        public ActionResult Mostrar2(String nombre)
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            SeccionEN result = cCAD.ReadFilter(nombre);
            IList<ArticuloEN> resultfinal = result.Tiene;
            IList<ArticuloDTO> resultadofinal = new List<ArticuloDTO>();
            foreach (ArticuloEN entry in resultfinal)
                resultadofinal.Add(new ArticuloAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }

        // GET: /Usuario/

        public ActionResult Lista()
        {
            SessionInitialize();
            SeccionCAD cCAD = new SeccionCAD(session);
            IList<SeccionEN> resultEN = cCAD.ReadAllDefault(0, 999);
            IList<SeccionDTO> result = new List<SeccionDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                result.Add(new SeccionAssembler().Convert(resultEN[i]));
            }
            SessionClose();
            return View(result);
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
            if (result == null)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }


        //
        // GET: /Seccion/Create

        public ActionResult Create()
        {
            SeccionEN sec = new SeccionEN();
            SeccionDTO secd = new SeccionAssembler().Convert(sec);
            return View(secd);
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
            SeccionEN resultEN = cCAD.ReadOIDDefault(id);
            SeccionDTO result = new SeccionAssembler().Convert(resultEN);
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
                cen.ModificarSeccion(sec.Seccion, sec.Nombre);
                return RedirectToAction("Details", new { id = sec.Seccion });
            }
            catch (Exception ex)
            {
                throw ex; //Si, a la ex.
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

            return RedirectToAction("Index");
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
