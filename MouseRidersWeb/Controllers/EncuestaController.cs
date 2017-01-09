using MouseRidersWeb.Assembler;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MouseRidersWeb.DTO;
using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersGenNHibernate.CP.MouseRiders;
namespace MouseRidersWeb.Controllers
{
    public class EncuestaController : BasicController
    {
        //
        // GET: /Encuesta/

        public ActionResult Index()
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            IList<EncuestaEN> encuestaEN = eCAD.ReadAllDefault(0, 999);
            IList<EncuestaDTO> lista = new List<EncuestaDTO>();
            for (int i = 0; i < encuestaEN.Count; i++)
            {
                lista.Add(new EncuestaAssembler().ConvertConPreguntaYRespuesta(encuestaEN[i]));
            }
            SessionClose();
            return View(lista);
        }

        //
        // GET: /Encuesta/Modelo/

        public ActionResult Modelo()
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            IList<EncuestaEN> encuestaEN = eCAD.ReadAllDefault(0, 999);
            EncuestaAssembler enc = new EncuestaAssembler();
            IList<EncuestaDTO> lista = new List<EncuestaDTO>();
            for (int i = 0; i < encuestaEN.Count; i++)
            {
                lista.Add(enc.ConvertConPreguntaYRespuesta(encuestaEN[i]));
            }
            SessionClose();
            return View(lista);
        }


        //
        // GET: /Encuesta/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            EncuestaEN encuesta_EN = eCAD.ReadOID(id);
            EncuestaDTO result = new EncuestaAssembler().ConvertConPreguntaYRespuesta(encuesta_EN);
            SessionClose();
            return View(result);
        }

        //
        // GET: /Encuesta/Realizar/5

        public ActionResult Realizar(int id)
        {
            SessionInitialize();
            EncuestaCAD eCAD = new EncuestaCAD(session);
            EncuestaEN encuesta_EN = eCAD.ReadOID(id);
            EncuestaDTO result = new EncuestaAssembler().ConvertConPreguntaYRespuesta(encuesta_EN);
            SessionClose();
            return View(result);
        }

        //
        // POST: /Encuesta/Realizar/5
        [HttpPost]
        public ActionResult Realizar(EncuestaEN encuesta, FormCollection form)
        {
            SessionInitialize();
            EncuestaEN encuestaEN = new EncuestaCAD(session).ReadOID(encuesta.Id);
            for (int i = 0; i < encuestaEN.Tiene.Count; i++)
            {
                PreguntaEN pregunta = encuestaEN.Tiene[i];
                for (int j = 0; j < pregunta.Tiene.Count; j++)
                {
                    RespuestaEN resp = pregunta.Tiene[j];
                    var radio = form.GetValues("Resp_" + i);
                    if (radio != null)
                    {
                        if (resp.Respuesta.Equals(radio[0]))
                        {
                            new RespuestaCEN().ModificarRespuesta(resp.Id, resp.Respuesta, resp.Tipo,
                                ++resp.Contador, resp.Frecuencia);
                            break;
                        }
                    }
                }
            }
            new EncuestaCEN(new EncuestaCAD(session)).GenerarEstadisticas();
            SessionClose();
            return (RedirectToAction("Details", new { id = encuestaEN.Id }));
        }

        //
        // GET: /Encuesta/Create

        public ActionResult Create()
        {
            SessionInitialize();
            EncuestaEN enc = new EncuestaEN();
            IList<PreguntaEN> Tiene = new List<PreguntaEN>();
            IList<RespuestaEN> Respuesta = new List<RespuestaEN>();
            for (int i = 0; i < 4; i++)
            {
                Respuesta.Add(new RespuestaEN());
            }
            for (int i = 0; i < 5; i++)
            {
                PreguntaEN Pregunta = new PreguntaEN();
                Pregunta.Pregunta = "pero " + i;
                Pregunta.Tiene = Respuesta;
                Tiene.Add(Pregunta);
            }
            enc.Titulo = "Totoro";
            enc.Descripcion = "Descripcion";
            enc.Privada = false;
            enc.Tiene = Tiene;
            EncuestaDTO result = new EncuestaAssembler().ConvertConPreguntaYRespuesta(enc);
            SessionClose();
            return View(result);
        }

        //
        // POST: /Encuesta/Create

        [HttpPost]
        public ActionResult Create(EncuestaEN enc, FormCollection form)
        {
            try
            {
                SessionInitialize();
                string[] strPregunta = form.GetValues("item.Pregunta");
                string[] strRespuesta = form.GetValues("respuesta.Respuesta");
                enc.Id = new EncuestaCEN().CrearEncuesta(enc.Titulo, enc.Descripcion, enc.Privada);
                IList<PreguntaEN> lista_preguntas = new List<PreguntaEN>();
                for (var i = 0; i < strPregunta.Length; i++)
                {
                    PreguntaEN pregunta = new PreguntaEN();
                    pregunta.Id = new PreguntaCEN().CrearPregunta(strPregunta[i], T_PreguntaEnum.radio, enc.Id);
                    IList<RespuestaEN> lista_respuestas = new List<RespuestaEN>();
                    for (var j = 0; j < strRespuesta.Length / strPregunta.Length; j++)
                    {
                        if (!strRespuesta[(strRespuesta.Length / strPregunta.Length) * i + j].Equals(""))
                        {
                            RespuestaEN respuesta = new RespuestaEN();
                            respuesta.Respuesta = strRespuesta[(strRespuesta.Length / strPregunta.Length) * i + j];
                            respuesta.Id = new RespuestaCEN().CrearRespuesta(respuesta.Respuesta, T_PreguntaEnum.radio, pregunta.Id, 0, 0);
                            lista_respuestas.Add(respuesta);
                        }
                    }
                    if (!strPregunta[i].Equals(""))
                    { // HAY PREGUNTA
                        if (lista_respuestas.Count >= 2) // SE NECESITAN 2 RESPUESTAS MINIMO
                        { // HAY RESPUESTAS
                            pregunta.Tiene = lista_respuestas;
                            new PreguntaCAD(session).ModificarPregunta(pregunta);
                            lista_preguntas.Add(pregunta);
                        }
                        else
                        {  // NO HAY RESPUESTAS - BORRAR PREGUNTA
                            new PreguntaCEN().BorrarPregunta(pregunta.Id);
                        }
                    }
                    else
                    { // NO HAY PREGUNTA - BORRAR PREGUNTA
                        if (lista_respuestas.Count != 0)
                        {// BORRAR LAS RESPUESTAS CREADAS
                            for (var j = 0; j < lista_respuestas.Count; j++)
                            {
                                new RespuestaCEN().BorrarRespuesta(lista_respuestas[i].Id);
                            }
                        }
                        new PreguntaCEN().BorrarPregunta(pregunta.Id);
                    }
                }
                DateTime p_fecha = DateTime.Now;
                enc.Tiene = lista_preguntas;
                new EncuestaCAD(session).ModificarEncuesta(enc);
                SessionClose();
                return (RedirectToAction("Details", new { id = enc.Id }));
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Encuesta/Edit/5

        public ActionResult Edit(int id)
        {
            EncuestaCAD eCAD = new EncuestaCAD();
            EncuestaEN result = eCAD.ReadOIDDefault(id);
            EncuestaDTO resultfinal = new EncuestaAssembler().Convert(result);
            return View(resultfinal);
        }

        //
        // POST: /Encuesta/Edit/5

        [HttpPost]
        public ActionResult Edit(EncuestaEN enc)
        {
            try
            {
                EncuestaCEN cen = new EncuestaCEN();
                cen.ModificarEncuesta(enc.Id, enc.Titulo, enc.Descripcion, enc.Privada);

                return RedirectToAction("Details", new { id = enc.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Encuesta/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            EncuestaCAD cCAD = new EncuestaCAD(session);
            EncuestaEN result = cCAD.ReadOIDDefault(id);
            EncuestaDTO resultfinal = new EncuestaAssembler().Convert(result);
            SessionClose();

            return View(resultfinal);
        }

        //
        // POST: /Encuesta/Delete/5

        [HttpPost]
        public ActionResult Delete(EncuestaEN enc)
        {
            try
            {
                new EncuestaCEN().BorrarEncuesta(enc.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
