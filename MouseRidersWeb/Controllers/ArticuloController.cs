
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Assembler;
using MouseRidersWeb.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers
{
    public class ArticuloController : BasicController
    {


        public ActionResult UploadContenido()
        {
            return View();
        }
        public ActionResult UploadContenidoDescargable()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadHTML(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Contenido/Articulos"), fileName);
                    file.SaveAs(path);
                }

                ViewBag.Message = "Upload successful";
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Upload failed";
                return RedirectToAction("Uploads");
            }
        }
        [HttpPost]
        public ActionResult UploadPDF(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Contenido/Articulos"), fileName);
                    file.SaveAs(path);
                }

                ViewBag.Message = "Upload successful";
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Upload failed";
                return RedirectToAction("Uploads");
            }
        }

        //
        // GET: /Articulo/

        public ActionResult Index()
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            IList<ArticuloEN> resultEN = cCAD.ReadAllDefault(0, 10);
            IList<ArticuloDTO> result = new List<ArticuloDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                result.Add(new ArticuloAssembler().Convert(resultEN[i]));
            }
            SessionClose();
            return View(result);
        }

        // GET: /Articulo/MostrarMiniaturas/3
        public ActionResult MostrarMiniaturas(int num)
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            IList<ArticuloEN> resultEN = cCAD.ReadAllDefault(num, 3);
            IList<ArticuloDTO> result = new List<ArticuloDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                result.Add(new ArticuloAssembler().Convert(resultEN[i]));
            }
            SessionClose();
            return PartialView(result);
        }



        //
        // GET: /Articulo/Details/294912

        public ActionResult Details(int id)
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            ArticuloEN resultEN = cCAD.ReadOIDDefault(id);
            ArticuloDTO result = new ArticuloAssembler().ConvertConComentario_Articulo(resultEN);
            SessionClose();
            return View(result);
        }

        public ActionResult Contenido(int id)
        {
            SessionInitialize();
            ArticuloCAD cCAD = new ArticuloCAD(session);
            ArticuloEN resultEN = cCAD.ReadOIDDefault(id);
            ArticuloDTO result = new ArticuloAssembler().ConvertConComentario_Articulo(resultEN);
            SessionClose();
            return View(result);
        }
        //
        // GET: /Articulo/Create

        public ActionResult Create()
        {
            ArticuloEN art = new ArticuloEN();
            ArticuloDTO result = new ArticuloAssembler().Convert(art);
            return View(result);
        }

        //
        // POST: /Articulo/Create

        [HttpPost]
        public ActionResult Create(ArticuloEN art, HttpPostedFileBase file, HttpPostedFileBase file_des)
        {
            try
            {
                ArticuloCAD cCAD = new ArticuloCAD();
                ArticuloCEN cen = new ArticuloCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                try
                {
                    if (file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Contenido/Articulos"), fileName);
                        file.SaveAs(path);
                    }
                    ViewBag.Message += "Upload contenido successful";
                    art.Contenido = file.FileName;
                }
                catch
                {
                    ViewBag.Message += "Upload contenido failed";
                }
                try
                {
                    if (file_des.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file_des.FileName);
                        var path = Path.Combine(Server.MapPath("~/Contenido/Articulos"), fileName);
                        file_des.SaveAs(path);
                    }
                    ViewBag.Message += "Upload contenido_descargable successful";
                    art.ContenidoDescargable = file_des.FileName;
                }
                catch
                {
                    ViewBag.Message += "Upload contenido_descargable failed";
                }
                int id = cen.CrearArticulo(art.Pertenece.Seccion, art.Titulo, art.Autor,
                    art.Contenido, art.ContenidoDescargable,
                    art.Puntuacion, p_fecha, art.Contador, art.Subtitulo, art.Portada, art.Descripcion);
                return RedirectToAction("Details", new { id = id });
            }
            catch
            {
                ViewBag.Message += "Error";
                return View();
            }
        }

        //
        // GET: /Articulo/Edit/5

        public ActionResult Edit(int id)
        {
            ArticuloCAD cCAD = new ArticuloCAD();
            ArticuloEN resultaux = cCAD.ReadOIDDefault(id);
            ArticuloDTO result = new ArticuloAssembler().Convert(resultaux);
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
            ArticuloDTO resultfinal = new ArticuloAssembler().Convert(result);
            SessionClose();
            return View(resultfinal);
        }

        //
        // POST: /Articulo/Delete/5

        [HttpPost]
        public ActionResult Delete(ArticuloEN art)
        {
            try
            {
                new ArticuloCEN().BorrarArticulo(art.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public void AnyadirEstrellas(int id, float valoracion)
        {
            ArticuloCEN cen = new ArticuloCEN();
            cen.ActualizarPuntuacion(id, valoracion);
        }

    }
}