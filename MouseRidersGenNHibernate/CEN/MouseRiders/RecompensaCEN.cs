

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
 *      Definition of the class RecompensaCEN
 *
 */
public partial class RecompensaCEN
{
private IRecompensaCAD _IRecompensaCAD;

public RecompensaCEN()
{
        this._IRecompensaCAD = new RecompensaCAD ();
}

public RecompensaCEN(IRecompensaCAD _IRecompensaCAD)
{
        this._IRecompensaCAD = _IRecompensaCAD;
}

public IRecompensaCAD get_IRecompensaCAD ()
{
        return this._IRecompensaCAD;
}

public int CrearRecompensa (string p_nombre, string p_descripcion, int p_puntuacion)
{
        RecompensaEN recompensaEN = null;
        int oid;

        //Initialized RecompensaEN
        recompensaEN = new RecompensaEN ();
        recompensaEN.Nombre = p_nombre;

        recompensaEN.Descripcion = p_descripcion;

        recompensaEN.Puntuacion = p_puntuacion;

        //Call to RecompensaCAD

        oid = _IRecompensaCAD.CrearRecompensa (recompensaEN);
        return oid;
}

public void ModificarRecompensa (int p_Recompensa_OID, string p_nombre, string p_descripcion, int p_puntuacion)
{
        RecompensaEN recompensaEN = null;

        //Initialized RecompensaEN
        recompensaEN = new RecompensaEN ();
        recompensaEN.Id = p_Recompensa_OID;
        recompensaEN.Nombre = p_nombre;
        recompensaEN.Descripcion = p_descripcion;
        recompensaEN.Puntuacion = p_puntuacion;
        //Call to RecompensaCAD

        _IRecompensaCAD.ModificarRecompensa (recompensaEN);
}

public void BorrarRecompensa (int id
                              )
{
        _IRecompensaCAD.BorrarRecompensa (id);
}

public RecompensaEN ReadOID (int id
                             )
{
        RecompensaEN recompensaEN = null;

        recompensaEN = _IRecompensaCAD.ReadOID (id);
        return recompensaEN;
}

public System.Collections.Generic.IList<RecompensaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecompensaEN> list = null;

        list = _IRecompensaCAD.ReadAll (first, size);
        return list;
}
}
}
