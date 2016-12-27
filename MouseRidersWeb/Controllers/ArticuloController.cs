
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
    public class ArticuloController : BasicController
    {
        //
        // GET: /Articulo/

        public ActionResult Index()
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            IList<ArticuloEN> result = cCAD.ReadAllDefault(0, 10);
            SessionClose();
            return View(result);
        }

        // GET: /Articulo/MostrarMiniaturas/3
        public ActionResult MostrarMiniaturas(int num)
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            IList<ArticuloEN> result = cCAD.ReadAllDefault(num, 3);
            SessionClose();
            return PartialView(result);
        }



        //
        // GET: /Articulo/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            ArticuloEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            return View(result);
        }


        //
        // GET: /Articulo/Create

        public ActionResult Create()
        {
            ArticuloEN art = new ArticuloEN();
            return View(art);
        }

        //
        // POST: /Articulo/Create

        [HttpPost]
        public ActionResult Create(ArticuloEN art)
        {
            try
            {
                ArticuloCAD cCAD = new ArticuloCAD();
                ArticuloCEN cen = new ArticuloCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                //cen.CrearArticulo(art.Pertenece,art.Titulo,art.Autor,art.Contenido,art.ContenidoDescargable,art.Puntuacion,p_fecha,art.Contador);
                return RedirectToAction("Details", new { id = art.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Articulo/Edit/5

        public ActionResult Edit(int id)
        {
            ArticuloCAD cCAD = new ArticuloCAD();
            ArticuloEN result = cCAD.ReadOIDDefault(id);
            return View(result);
        }

        //
        // POST: /Articulo/Edit/5

        [HttpPost]
        public ActionResult Edit(ArticuloEN art)
        {
            try
            {
                ArticuloCEN cen = new ArticuloCEN();
                cen.ModificarArticulo(art.Id, art.Titulo, art.Autor, art.Contenido, art.ContenidoDescargable, art.Puntuacion, art.Fecha, art.Contador, art.Subtitulo, art.Portada, art.Descripcion);

                return RedirectToAction("Details", new { id = art.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Articulo/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            ArticuloEN result = cCAD.ReadOIDDefault(id);
            SessionClose();
            new ArticuloCEN().BorrarArticulo(id);

            return View(result);
        }

        //
        // POST: /Articulo/Delete/5

        [HttpPost]
        public ActionResult Delete(ArticuloEN art)
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