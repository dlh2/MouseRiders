
using MouseRidersWeb.Assembler;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersWeb.DTO;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MouseRidersWeb.Controllers
{
    public class UsuarioController : BasicController
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            SessionInitialize();
            UsuarioCAD cCAD = new UsuarioCAD(session);
            IList<UsuarioEN> resultEN = cCAD.ReadAllDefault(0,10);
            IList<UsuarioDTO> result = new List<UsuarioDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                result.Add(new UsuarioAssembler().Convert(resultEN[i]));
            }
            SessionClose();
            return View(result);
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            UsuarioCAD cCAD = new UsuarioCAD(session);
            UsuarioEN result = cCAD.ReadOIDDefault(id);
            UsuarioDTO resultfinal = new UsuarioAssembler().Convert(result);
            SessionClose();
            return View(resultfinal);
        }

        //
        // GET: /Usuario/Denuncias/5

        public ActionResult VerDenunciasRecibidas(int id)
        {
            SessionInitialize();
            UsuarioCAD cCAD = new UsuarioCAD(session);
            UsuarioEN cCEN = cCAD.ReadOIDDefault(id);
            IList<DenunciaEN> result = cCEN.RecibeD;
            return View(result);
        }

        public ActionResult Login()
        {
            UsuarioDTO result = new UsuarioDTO();
            return View(result);
        }

        [HttpPost]
        public ActionResult Login(UsuarioEN model)
        {

            //int user_rol = new UsuarioCEN().Autenticar(model.Nombreusuario,model.Contrasenya);
            int user_rol = 2;
            if (user_rol == -1)
            {
                // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
                ModelState.AddModelError("", "El nombre de usuario o la contraseña especificados son incorrectos.");
                return View(new UsuarioAssembler().Convert(model));
            }
            Session["user_rol"] = "" + user_rol;
            Session["user_name"] = model.Nombreusuario;
            return RedirectToAction("Index","Home");
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            UsuarioEN usu = new UsuarioEN();
            return View(usu);
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create (UsuarioEN usu)
        {
            try
            {
                UsuarioCAD cCAD = new UsuarioCAD();
                UsuarioCEN cen = new UsuarioCEN(cCAD);
                DateTime p_fecha = DateTime.Now;
                cen.CrearUsuario(usu.Email, usu.Nombre, usu.Apellidos, usu.Pais, usu.Telefono, 0, p_fecha, usu.Contrasenya, usu.Nombreusuario) ;

                return RedirectToAction("Details", new { id = usu.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            UsuarioCAD cCAD = new UsuarioCAD();
            UsuarioEN resultEN = cCAD.ReadOIDDefault(id);
            UsuarioDTO result = new UsuarioAssembler().Convert(resultEN);
            return View(result);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(UsuarioEN usu)
        {
            try
            {
                UsuarioCEN cen = new UsuarioCEN();
                cen.ModificarUsuario(usu.Id, usu.Email, usu.Nombre, usu.Apellidos, usu.Pais, usu.Telefono, usu.Puntuacion, usu.FechaRegistro, usu.Contrasenya, usu.Nombreusuario);

                return RedirectToAction("Details", new { id = usu.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            UsuarioCAD cCAD = new UsuarioCAD(session);
            UsuarioEN result = cCAD.ReadOIDDefault(id);
            UsuarioDTO resultfinal = new UsuarioAssembler().Convert(result);
            SessionClose();

            return View(resultfinal);
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost]
        public ActionResult Delete(UsuarioEN usu)
        {
            try
            {
                new UsuarioCEN().BorrarUsuario(usu.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
