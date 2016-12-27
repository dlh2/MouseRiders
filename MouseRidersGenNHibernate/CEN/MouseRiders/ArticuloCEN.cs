

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.Exceptions;

using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;


namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
/*
 *      Definition of the class ArticuloCEN
 *
 */
public partial class ArticuloCEN
{
private IArticuloCAD _IArticuloCAD;

public ArticuloCEN()
{
        this._IArticuloCAD = new ArticuloCAD ();
}

public ArticuloCEN(IArticuloCAD _IArticuloCAD)
{
        this._IArticuloCAD = _IArticuloCAD;
}

public IArticuloCAD get_IArticuloCAD ()
{
        return this._IArticuloCAD;
}

public int CrearArticulo (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum p_pertenece, string p_titulo, string p_autor, string p_contenido, string p_contenidoDescargable, float p_puntuacion, Nullable<DateTime> p_fecha, int p_contador, string p_subtitulo, string p_portada, string p_descripcion)
{
        ArticuloEN articuloEN = null;
        int oid;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();

        if (p_pertenece != null) {
                // El argumento p_pertenece -> Property pertenece es oid = false
                // Lista de oids id
                articuloEN.Pertenece = new MouseRidersGenNHibernate.EN.MouseRiders.SeccionEN ();
                articuloEN.Pertenece.Seccion = p_pertenece;
        }

        articuloEN.Titulo = p_titulo;

        articuloEN.Autor = p_autor;

        articuloEN.Contenido = p_contenido;

        articuloEN.ContenidoDescargable = p_contenidoDescargable;

        articuloEN.Puntuacion = p_puntuacion;

        articuloEN.Fecha = p_fecha;

        articuloEN.Contador = p_contador;

        articuloEN.Subtitulo = p_subtitulo;

        articuloEN.Portada = p_portada;

        articuloEN.Descripcion = p_descripcion;

        //Call to ArticuloCAD

        oid = _IArticuloCAD.CrearArticulo (articuloEN);
        return oid;
}

public void ModificarArticulo (int p_Articulo_OID, string p_titulo, string p_autor, string p_contenido, string p_contenidoDescargable, float p_puntuacion, Nullable<DateTime> p_fecha, int p_contador, string p_subtitulo, string p_portada, string p_descripcion)
{
        ArticuloEN articuloEN = null;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Id = p_Articulo_OID;
        articuloEN.Titulo = p_titulo;
        articuloEN.Autor = p_autor;
        articuloEN.Contenido = p_contenido;
        articuloEN.ContenidoDescargable = p_contenidoDescargable;
        articuloEN.Puntuacion = p_puntuacion;
        articuloEN.Fecha = p_fecha;
        articuloEN.Contador = p_contador;
        articuloEN.Subtitulo = p_subtitulo;
        articuloEN.Portada = p_portada;
        articuloEN.Descripcion = p_descripcion;
        //Call to ArticuloCAD

        _IArticuloCAD.ModificarArticulo (articuloEN);
}

public void BorrarArticulo (int id
                            )
{
        _IArticuloCAD.BorrarArticulo (id);
}

public ArticuloEN ReadOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        articuloEN = _IArticuloCAD.ReadOID (id);
        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> list = null;

        list = _IArticuloCAD.ReadAll (first, size);
        return list;
}
}
}
