using MRModel.CAD;
using MRModel.CEN;
using MRModel.EN;
using MRWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRWeb.Controllers
{
    public class MensajeController : BasicController
    {
        // GET: Mensaje
        public ActionResult Index()
        {
            MensajeCEN _MensajeCEN = new MensajeCEN();
            IList<MensajeEN> mensajes = _MensajeCEN.ReadAll(0, 10);
            return View(mensajes);
        }

        // GET: Mensaje/Details/5
        public ActionResult Details(int id)
        {
            MensajeCEN _MensajeCAD = new MensajeCEN();
            MensajeEN mensaje = _MensajeCAD.ReadOID(id);
            return View(mensaje);
        }

        // GET: Mensaje/Create
        public ActionResult Create(int id)
        {
            //En el ejemplo hay un int id.
            MensajeEN mensaje = new MensajeEN();
            mensaje.Id = id;
            return View(mensaje);
        }

        // POST: Mensaje/Create
        [HttpPost]
        public ActionResult Create(MensajeEN mensaje)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                // TODO: Parece que aqui siempre hay que cambiar algo.
                MensajeCEN cen = new MensajeCEN();
                IList<int> aux = new List<int>();
                for (int i = 0; i < mensaje.Es_recibido.Count; i++)
                    aux.Add(mensaje.Es_recibido[i].Id);
                cen.CrearMensaje(mensaje.Asunto, mensaje.Texto, mensaje.Adjunto, mensaje.Tipo, mensaje.Es_enviado.Id, aux);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mensaje/Edit/5
        public ActionResult Edit(int id)
        {
            MensajeCEN cen = new MensajeCEN();
            MensajeEN mensaje = cen.ReadOID(id);
            return View(mensaje);
        }

        // POST: Mensaje/Edit/5
        [HttpPost]
        public ActionResult Edit(MensajeEN mensaje)
        {
            try
            {
                // En el ejemplo, se procura que devuelva la clase directamente, no se como, pero lo hace.
                MensajeCEN cen = new MensajeCEN();
                cen.ModificarMensaje(mensaje.Id, mensaje.Asunto,mensaje.Texto,mensaje.Adjunto,mensaje.Tipo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mensaje/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                //Como ya se sabe cual se elimina, y no dejamos si confirmamos o no, pues con un GET delete va que chuta.
                new MensajeCEN().BorrarMensaje(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Mensaje/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
