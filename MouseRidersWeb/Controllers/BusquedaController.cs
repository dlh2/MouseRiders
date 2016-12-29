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
using System.Diagnostics;

namespace MouseRidersWeb.Controllers
{
    public class BusquedaController : BasicController
    {
        /**
         * Buscador: permite introducir la cadena de caracteres por la que se busca
Mostrar: permite elegir el rango de resultados, es decir, buscar solo en artículos, buscar solo en usuarios, buscar solo en hilos o buscar en todos.
Fecha: permite mostrar los artículos e hilos que sean menores o mayores que la fecha estipulada 
Valoración: muestra los artículos que sean menores o mayores que la valoración estipulada.
*/


        //
        // Ajax GET: /Busqueda/
        public ActionResult Index(String buscar, int mostrar, Nullable<DateTime> fecha,int valoracion)
        {
            if(mostrar>>1==2){

            }
            if(mostrar/2==2){

            }
            if(mostrar/2==2){

            }
            SessionInitialize();
            ComentarioCAD cCAD = new ComentarioCAD(session);
            IList<ComentarioEN> resultEN;
            if (Request.IsAjaxRequest())
            {
                int a = Int32.Parse(buscar) * 10;
                resultEN = cCAD.ReadAllDefault(a, 10);
            }
            else
            {
                resultEN = cCAD.ReadAllDefault(0, 10);
            }
            IList<ComentarioDTO> result = new List<ComentarioDTO>();
            for (int i = 0; i < resultEN.Count; i++)
            {
                result.Add(new ComentarioAssembler().Convert(resultEN[i]));
            }
            SessionClose();
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Busqueda", result);
            }
            return View(result);
        }
    }
}
