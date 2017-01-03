using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MouseRidersWeb.Assembler;
using System.Diagnostics;

namespace MouseRidersWeb.Controllers
{
    public class BusquedaController : BasicController
    {
        /**
         * Buscador: permite introducir la cadena de caracteres por la que se busca
         * Mostrar: permite elegir el rango de resultados, es decir, buscar solo en artículos, buscar solo en usuarios,
         *          buscar solo en hilos o buscar en todos.
         * Fecha: permite mostrar los artículos e hilos que sean menores o mayores que la fecha estipulada 
         * Valoración: muestra los artículos que sean menores o mayores que la valoración estipulada.
         */

        //
        // Ajax GET: /Busqueda/
        public ActionResult Index(String buscar, int mostrar, Nullable<DateTime> fecha, Nullable<int> valoracion)
        {
            int i = 1;
            String array = "";
            for (i = 1; mostrar >= 2; mostrar /= 2, i++)
            {
                array = +mostrar % 2 + ",";
            }
            array = +mostrar + ",";
            bool[] mostrar_aux = new bool[7];
            String[] array_aux = array.Split(new char[] { ',' });
            int limite = array_aux.Length;
            for (int a = 0; a < mostrar_aux.Length; a++)
            {
                mostrar_aux[a] = a >= limite ? false : array_aux[a] == "1";
            }
            // 1000000 = Articulos
            // 0100000 = Usuarios
            // 0010000 = Hilos
            // 0001000 = Menor Fecha
            // 0000100 = Mayor Fecha
            // 0000010 = Menor Valoracion
            // 0000001 = Mayor Valoracion
            if (mostrar_aux[0]) //Articulos
            {

            }
            if (mostrar_aux[1]) //Usuarios
            {

            }
            if (mostrar_aux[2]) //Hilos
            {

            }
            if (mostrar_aux[3]) //Menor Fecha
            {

            }
            if (mostrar_aux[4]) //Mayor Fecha
            {

            }
            if (mostrar_aux[5]) //Menor Valoracion
            {

            }
            if (mostrar_aux[6]) //Mayor Valoracion
            {

            }
            SessionInitialize();
            BusquedaDTO result = null;
            SessionClose();
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Busqueda", result);
            }
            return View(result);
        }
    }
}
