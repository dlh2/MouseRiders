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
        // GET: /Permiso/Permisos/5

        public ActionResult Permisos(T_RolEnum rol)
        {
            SessionInitialize();
            PermisoCAD permisoCAD = new PermisoCAD(session);
            IList<PermisoEN> permisoEN = permisoCAD.ReadFilter(rol, null);
            IList<PermisoDTO> result = new List<PermisoDTO>();
            foreach (PermisoEN entry in permisoEN)
                result.Add(new PermisoAssembler().Convert(entry));
            SessionClose();
            return View(result);
        }

        //
        // GET: /Permiso/Details/5
        public ActionResult Details(T_RolEnum rol, string permiso)
        {
            SessionInitialize();
            PermisoCAD permisoCAD = new PermisoCAD(session);
            IList<PermisoEN> permisoEN = permisoCAD.ReadFilter(rol, permiso);
            PermisoDTO result = new PermisoAssembler().Convert(permisoEN[0]);
            SessionClose();
            return View(result);
        }
        //
        // GET: /Permiso/Create

        public ActionResult Create()
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
                cen.CrearPermiso(permiso.PermisoOID.Rol, permiso.PermisoOID.Permiso, permiso.Permisos);
                return RedirectToAction("Details", new { id = permiso.PermisoOID.Rol });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Permiso/Edit/5/permiso
        public ActionResult Edit(T_RolEnum rol, string permiso)
        {
            SessionInitialize();
            PermisoCAD permisoCAD = new PermisoCAD(session);
            IList<PermisoEN> permisoEN = permisoCAD.ReadFilter(rol, permiso);
            PermisoDTO result = new PermisoAssembler().Convert(permisoEN[0]);
            SessionClose();
            return View(result);
        }

        //
        // POST: /Permiso/Edit/5/permiso

        [HttpPost]
        public ActionResult Edit(T_RolEnum rol, string permiso, string permisos)
        {
            try
            {
                PermisoCEN permisoCEN = new PermisoCEN();
                PermisoEN_OID per = new PermisoEN_OID(rol, permiso);
                permisoCEN.ModificarPermiso(per, permisos);
                return RedirectToAction("Details", new { rol = rol, permiso = permiso });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Permiso/Delete/5
        public ActionResult Delete(T_RolEnum rol, string permiso)
        {
            // TODO: PERMISO ELIMINAR NO FUNCIONA
            try
            {
                SessionInitialize();
                PermisoCAD cad = new PermisoCAD(session);
                new PermisoCEN(cad).BorrarPermiso(new PermisoEN_OID(rol, permiso));
                SessionClose();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //
        // GET: /Permiso/Delete/5
        public ActionResult DeletePermisos(T_RolEnum rol)
        {
            try
            {
                // TODO: Add delete logic here
                SessionInitialize();
                PermisoCAD permisoCAD = new PermisoCAD(session);
                PermisoCEN permisoCEN = new PermisoCEN(permisoCAD);
                IList<PermisoEN> permiso = permisoCAD.ReadFilter(rol, null);
                permiso.Clear();
                SessionClose();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
