

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
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int CrearComentario (string p_creador, Nullable<DateTime> p_fecha, string p_contenido, int p_valoracion)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Creador = p_creador;

        comentarioEN.Fecha = p_fecha;

        comentarioEN.Contenido = p_contenido;

        comentarioEN.Valoracion = p_valoracion;

        //Call to ComentarioCAD

        oid = _IComentarioCAD.CrearComentario (comentarioEN);
        return oid;
}

public void ModificarComentario (int p_Comentario_OID, string p_creador, Nullable<DateTime> p_fecha, string p_contenido, int p_valoracion)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Creador = p_creador;
        comentarioEN.Fecha = p_fecha;
        comentarioEN.Contenido = p_contenido;
        comentarioEN.Valoracion = p_valoracion;
        //Call to ComentarioCAD

        _IComentarioCAD.ModificarComentario (comentarioEN);
}

public void BorrarComentario (int id
                              )
{
        _IComentarioCAD.BorrarComentario (id);
}

public void RelacionaArticulo (int p_Comentario_OID, int p_pertenece_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.RelacionaArticulo (p_Comentario_OID, p_pertenece_OID);
}
public void RelacionaHilo (int p_Comentario_OID, int p_pertenece_a_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.RelacionaHilo (p_Comentario_OID, p_pertenece_a_OID);
}
public int NumComentsArticulo (int ? p_id)
{
        return _IComentarioCAD.NumComentsArticulo (p_id);
}
public int NumComentsHilo (int ? p_id)
{
        return _IComentarioCAD.NumComentsHilo (p_id);
}
}
}
