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
    public class PermisoController : BasicController
    {
        //
        // GET: /Permiso/

        public ActionResult Index()
        {
            SessionInitialize();
            PermisoCAD permisoCAD = new PermisoCAD(session);
            IList<PermisoEN> permisoEN = permisoCAD.ReadAllDefault(0, 10);
            IList<PermisoDTO> resultfinal = new List<PermisoDTO>();
            foreach (PermisoEN entry in permisoEN)
                resultfinal.Add(new PermisoAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }

        //
        // GET: /Permiso/Details/5
        /*
        public ActionResult Details(T_RolEnum rol)
        {
            SessionInitialize();
            PermisoCAD permisoCAD = new PermisoCAD(session);
            IList<PermisoEN> result = permisoCAD.ReadFilter(rol);
            SessionClose();
            return View(result);
        }*/

        //
        // GET: /Permiso/Create

        public ActionResult Create(int id)
        {
            PermisoEN permiso = new PermisoEN();
            PermisoDTO result = new PermisoAssembler().Convert(permiso);
            return View(result);
        }

        //
        // POST: /Permiso/Create

        [HttpPost]
        public ActionResult Create(PermisoEN permiso)
        {
            try
            {
                PermisoCAD cCAD = new PermisoCAD();
                PermisoCEN cen = new PermisoCEN(cCAD);
                //cen.CrearPermiso(permiso.PermisoOID,permiso,permiso.Permisos);
                return RedirectToAction("Details", new { id = permiso.PermisoOID });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Permiso/Edit/5
        /*
        public ActionResult Edit(T_RolEnum rol)
        {
            SessionInitialize();
            PermisoCAD permisoCAD = new PermisoCAD(session);
            IList<PermisoEN> permiso = permisoCAD.ReadFilter(rol);
            SessionClose();
            return View(permiso);
        }*/

        //
        // POST: /Permiso/Edit/5

        [HttpPost]
        public ActionResult Edit(PermisoEN permiso)
        {
            try
            {
                PermisoCEN permisoCEN = new PermisoCEN();
                permisoCEN.ModificarPermiso(permiso.PermisoOID, permiso.Permisos);
                return RedirectToAction("Details", new { id = permiso.PermisoOID });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Permiso/Delete/5
        /*
        public ActionResult Delete(T_RolEnum rol)
        {
            try
            {
                // TODO: Add delete logic here
                SessionInitialize();
                PermisoCAD permisoCAD = new PermisoCAD(session);
                PermisoCEN permisoCEN = new PermisoCEN(permisoCAD);
                IList<PermisoEN> permiso = permisoCAD.ReadFilter(rol);
                permiso.Clear();
                SessionClose();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        */
        //
        // POST: /Permiso/Delete/5

        [HttpPost]
        public ActionResult Delete(PermisoEN permiso)
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
