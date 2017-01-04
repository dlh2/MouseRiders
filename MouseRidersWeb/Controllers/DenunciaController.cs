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
    public class DenunciaController : BasicController
    {
        //
        // GET: /Denuncia/

        public ActionResult Index()
        {
            SessionInitialize();
            DenunciaCAD denunciaCAD = new DenunciaCAD(session);
            IList<DenunciaEN> denunciaEN = denunciaCAD.ReadAllDefault(0, 10);
            SessionClose();
            return View(denunciaEN);
        }

        //
        // GET: /Denuncia/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            DenunciaCAD denunciaCAD = new DenunciaCAD(session);
            DenunciaEN result = denunciaCAD.ReadOIDDefault(id);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Denuncia/Create

        public ActionResult Create(int id)
        {
            DenunciaEN denuncia = new DenunciaEN();
            DenunciaDTO result = new DenunciaAssembler().Convert(denuncia);
            return View(result);
        }

        //
        // POST: /Denuncia/Create

        [HttpPost]
        public ActionResult Create(DenunciaEN denuncia)
        {
            try
            {
                
                DenunciaCAD cCAD = new DenunciaCAD();
                DenunciaCEN cen = new DenunciaCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                int id=cen.CrearDenuncia (denuncia.Motivo, denuncia.Es_creada.Id,p_fecha,denuncia.Es_recibida.Id);
                return RedirectToAction("Details", new { id = id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Denuncia/Edit/5

        public ActionResult Edit(int id)
        {
            SessionInitialize();
            DenunciaCAD denunciaCAD = new DenunciaCAD(session);
            DenunciaEN result = denunciaCAD.ReadOIDDefault(id);
            DenunciaDTO resultfinal = new DenunciaAssembler().Convert(result);
            return View(resultfinal);
        }

        //
        // POST: /Denuncia/Edit/5

        [HttpPost]
        public ActionResult Edit(DenunciaEN denuncia)
        {
            try
            {
                DenunciaCEN denunciaCEN = new DenunciaCEN();
                denunciaCEN.ModificarDenuncia(denuncia.Id, denuncia.Motivo, DateTime.Now);
                return RedirectToAction("Details", new { id = denuncia.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Denuncia/Delete/5

        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                SessionInitialize();
                DenunciaCAD denunciaCAD = new DenunciaCAD(session);
                DenunciaEN result = denunciaCAD.ReadOIDDefault(id);
                DenunciaDTO resultfinal = new DenunciaAssembler().Convert(result);
                SessionClose();

                return View(resultfinal);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Denuncia/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                new DenunciaCEN().BorrarDenuncia(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
