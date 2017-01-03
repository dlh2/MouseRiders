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
    public class RespuestaController : BasicController
    {
        //
        // GET: /Respuesta/

        public ActionResult Index()
        {
            SessionInitialize();
            RespuestaCAD cCAD = new RespuestaCAD(session);
            IList<RespuestaEN> result = cCAD.ReadAllDefault(0, 10);
            IList<RespuestaDTO> resultfinal = new List<RespuestaDTO>();
            foreach (RespuestaEN entry in result)
                resultfinal.Add(new RespuestaAssembler().Convert(entry));
            SessionClose();
            return View(resultfinal);
        }
    }
}
