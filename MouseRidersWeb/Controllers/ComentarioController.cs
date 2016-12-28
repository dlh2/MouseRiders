using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.DTO.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MouseRidersGenNHibernate.Assembler.MouseRiders;

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
            IList<ComentarioEN> resultEN = cCAD.ReadAllDefault(0, 10);
            IList<ComentarioDTO> result = new List<ComentarioDTO>();
            for (int i = 0; i < resultEN.Count; i++)
			{
                result.Add(new ComentarioAssembler().Convert(resultEN[i]));
			}
            SessionClose();
            return View(result);
        }

        //
        // GET: /Comentario/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            ComentarioCAD cCAD = new ComentarioCAD(session);
            ComentarioEN resultEN = cCAD.ReadOIDDefault(id);
            ComentarioDTO result = new ComentarioAssembler().Convert(resultEN);
            SessionClose();
            return View(result);
        }


        //
        // GET: /Comentario/Create

        public ActionResult Create()
        {
            ComentarioEN com = new ComentarioEN();
            ComentarioDTO result = new ComentarioAssembler().Convert(com);
            return View(result);
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
                int id = cen.CrearComentario(com.Creador,p_fecha,com.Contenido,com.Valoracion);
                return RedirectToAction("Details", new { id = id });
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
            ComentarioEN resultEN = cCAD.ReadOIDDefault(id);
            ComentarioDTO result = new ComentarioAssembler().Convert(resultEN);
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
            ComentarioEN resultEN = cCAD.ReadOIDDefault(id);
            ComentarioDTO result = new ComentarioAssembler().Convert(resultEN);
            SessionClose();
            

            return View(result);
        }

        //
        // POST: /Comentario/Delete/5

        [HttpPost]
        public ActionResult Delete(ComentarioEN com)
        {
            try
            {
                new ComentarioCEN().BorrarComentario(com.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
