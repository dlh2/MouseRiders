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
    public class HiloController : BasicController
    {
        //
        // GET: /Hilo/

        public ActionResult Index()
        {
            SessionInitialize();
            HiloCAD cCAD = new HiloCAD(session);
            IList<HiloEN> result = cCAD.ReadAllDefault(0, 10);
            IList<HiloDTO> resultfinal = new List<HiloDTO>();
            foreach (HiloEN entry in result)
                resultfinal.Add(new HiloAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }

        //
        // GET: /Hilo/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            HiloCAD cCAD = new HiloCAD(session);
            HiloEN result = cCAD.ReadOIDDefault(id);
            HiloDTO resultfinal = new HiloAssembler().ConvertConComentario_Hilo(result);
            SessionClose();
            return View(resultfinal);
        }


        //
        // GET: /Hilo/Create

        public ActionResult Create()
        {
            HiloEN hilo = new HiloEN();
            HiloDTO result = new HiloAssembler().Convert(hilo);
            return View(result);
        }

        //
        // POST: /Hilo/Create

        [HttpPost]
        public ActionResult Create(HiloEN hilo, ComentarioEN comentario)
        {
            try
            {
                ComentarioCAD comCAD = new ComentarioCAD();
                ComentarioCEN comCEN = new ComentarioCEN(comCAD);

                HiloCAD cCAD = new HiloCAD();
                HiloCEN cen = new HiloCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                IList<ComentarioEN> com = new List<ComentarioEN>();

                int cid=comCEN.CrearComentario(hilo.Creador, p_fecha, comentario.Contenido, 0);
                
                com.Add(comCEN.ReadOID(cid));
                int id=cen.CrearHilo(hilo.Creador,p_fecha,hilo.NumComentarios, com, hilo.Titulo);
                return RedirectToAction("Details", new { id = id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Hilo/Edit/5

        public ActionResult Edit(int id)
        {
            HiloCAD cCAD = new HiloCAD();
            HiloEN result = cCAD.ReadOIDDefault(id);
            HiloDTO resultfinal = new HiloAssembler().Convert(result);
            return View(resultfinal);
        }

        //
        // POST: /Hilo/Edit/5

        [HttpPost]
        public ActionResult Edit(HiloEN hilo)
        {
            try
            {
                HiloCEN cen = new HiloCEN();
                cen.ModificarHilo(hilo.Id,hilo.Creador, hilo.Fecha, hilo.NumComentarios, hilo.Titulo);

                return RedirectToAction("Details", new { id = hilo.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Hilo/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            HiloCAD cCAD = new HiloCAD(session);
            HiloEN result = cCAD.ReadOIDDefault(id);
            HiloDTO resultfinal = new HiloAssembler().Convert(result);
            SessionClose();

            return View(resultfinal);
        }

        //
        // POST: /Hilo/Delete/5

        [HttpPost]
        public ActionResult Delete(HiloEN hilo)
        {
            try
            {
                new HiloCEN().BorrarHilo(hilo.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}