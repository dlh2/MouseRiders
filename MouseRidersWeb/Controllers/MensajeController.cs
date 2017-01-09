using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.Assembler;
using MouseRidersWeb.Controllers;
using MouseRidersWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseRidersWeb.Controllers
{
    public class MensajeController : BasicController
    {
        // GET: /Mensaje/Create

        public ActionResult Create()
        {
            MensajeEN men = new MensajeEN();
            MensajeDTO result = new MensajeAssembler().Convert(men);
            return View(result);
        }

        //
        // POST: /Mensaje/Create
        
        [HttpPost]
        public ActionResult Create(MensajeDTO men)
        {
            
                MensajeCAD cCAD = new MensajeCAD();
                MensajeCEN cen = new MensajeCEN(cCAD);

                UsuarioCAD uCAD = new UsuarioCAD();
                UsuarioCEN ucen = new UsuarioCEN(uCAD);
                string aux1 = Session["user_email"].ToString();
                int oid = ucen.ReadFilterPorEmail(aux1).Id;

                IList<int> aux = new List<int>();
                UsuarioEN pepe = ucen.ReadFilterPorEmail(men.Destinatario);
                if (pepe != null)
                {
                    aux.Add(pepe.Id);
                }
                else
                {
                    
                    return RedirectToAction("Details", "Usuario", new { id = Session["user_id"].ToString(), error="si" });
                }
                
                int id = cen.CrearMensaje(men.Asunto, men.Texto, "default", men.Tipo, oid, aux);

                return RedirectToAction("Details", new { id = id });
       
        }

        // GET: /Mensaje/Create

        public ActionResult Sugerir()
        {
            MensajeEN men = new MensajeEN();
            MensajeDTO result = new MensajeAssembler().Convert(men);
            return View(result);
        }

        //
        // POST: /Mensaje/Create

        [HttpPost]
        public ActionResult Sugerir(MensajeEN men)
        {

            MensajeCAD cCAD = new MensajeCAD();
            MensajeCEN cen = new MensajeCEN(cCAD);
            IList<int> aux = new List<int>();
            aux.Add(32768);
            int id = cen.CrearMensaje(men.Asunto, men.Texto, "default", men.Tipo, 32768, aux);

            return RedirectToAction("Details", new { id = id });

        }

        // GET: /Mensaje/Create

        public ActionResult Redactor()
        {
            MensajeEN men = new MensajeEN();
            MensajeDTO result = new MensajeAssembler().Convert(men);
            return View(result);
        }

        //
        // POST: /Mensaje/Create

        [HttpPost]
        public ActionResult Redactor(MensajeEN men)
        {

            MensajeCAD cCAD = new MensajeCAD();
            MensajeCEN cen = new MensajeCEN(cCAD);
            IList<int> aux = new List<int>();
            aux.Add(32768);
            int id = cen.CrearMensaje(men.Asunto, men.Texto, "default", men.Tipo, 32768, aux);

            return RedirectToAction("Details", new { id = id });

        }

        // GET: /Mensaje/Create

        public ActionResult Administrador()
        {
            MensajeEN men = new MensajeEN();
            MensajeDTO result = new MensajeAssembler().Convert(men);
            return View(result);
        }

        //
        // POST: /Mensaje/Create

        [HttpPost]
        public ActionResult Administrador(MensajeEN men)
        {

            MensajeCAD cCAD = new MensajeCAD();
            MensajeCEN cen = new MensajeCEN(cCAD);
            IList<int> aux = new List<int>();
            aux.Add(32768);
            int id = cen.CrearMensaje(men.Asunto, men.Texto, "default", men.Tipo, 32768, aux);

            return RedirectToAction("Details", new { id = id });

        }

        // GET: /Mensaje/Create

        public ActionResult Solicitar()
        {
            MensajeEN men = new MensajeEN();
            MensajeDTO result = new MensajeAssembler().Convert(men);
            return View(result);
        }

        //
        // POST: /Mensaje/Create

        [HttpPost]
        public ActionResult Solicitar(MensajeEN men)
        {

            MensajeCAD cCAD = new MensajeCAD();
            MensajeCEN cen = new MensajeCEN(cCAD);
            IList<int> aux = new List<int>();
            aux.Add(32768);
            int id = cen.CrearMensaje(men.Asunto, men.Texto, "default", men.Tipo, 32768, aux);

            return RedirectToAction("Details", new { id = id });

        }

        // GET: /Mensaje/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            MensajeCAD cCAD = new MensajeCAD(session);
            MensajeEN result = cCAD.ReadOIDDefault(id);
            MensajeDTO resultfinal = new MensajeAssembler().Convert(result);
            SessionClose();
            return View(resultfinal);
        }
    }
}

