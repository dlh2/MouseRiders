
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Articulo_actualizarPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class ArticuloCEN
{
public float ActualizarPuntuacion (int p_Articulo_OID, float puntuacion)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Articulo_actualizarPuntuacion) ENABLED START*/

        // Write here your custom code...
        /*actualizarPuntuacion: recibe una nueva puntuacion, la guarda en un array (tal vez hay que tener un array de puntuaciones)
         *  y a partir de todas las puntuaciones almacenadas genera y devuelve la media*/
        float aux;
        int contador;
        ArticuloEN articuloEN = null;
        IArticuloCAD _IArticuloCAD = new ArticuloCAD ();
        ArticuloCEN articuloCEN = new ArticuloCEN (_IArticuloCAD);

        if (puntuacion < 0) {
                puntuacion = 0;
        }
        articuloEN = _IArticuloCAD.ReadOID (p_Articulo_OID);
        aux = articuloEN.Puntuacion;
        contador = articuloEN.Contador;
        aux = aux * contador;
        contador++;
        articuloEN.Contador = contador;
        puntuacion = (aux + puntuacion) / contador;
        articuloEN.Puntuacion = puntuacion;
        articuloCEN.ModificarArticulo (articuloEN.Id, articuloEN.Titulo, articuloEN.Autor, articuloEN.Contenido, articuloEN.ContenidoDescargable, articuloEN.Puntuacion, articuloEN.Fecha, articuloEN.Contador, articuloEN.Subtitulo, articuloEN.Portada, articuloEN.Descripcion);

        return(articuloEN.Puntuacion);

        /*PROTECTED REGION END*/
}
}
}
