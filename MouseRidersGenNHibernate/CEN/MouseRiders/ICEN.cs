

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
 *      Definition of the class ICEN
 *
 */
public partial class ICEN
{
private IICAD _IICAD;

public ICEN()
{
        this._IICAD = new ICAD ();
}

public ICEN(IICAD _IICAD)
{
        this._IICAD = _IICAD;
}

public IICAD get_IICAD ()
{
        return this._IICAD;
}

public int CrearBloqueo (System.Collections.Generic.IList<int> p_contiene, string p_usuarioBloqueado, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        IEN iEN = null;
        int oid;

        //Initialized IEN
        iEN = new IEN ();

        iEN.Contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
        if (p_contiene != null) {
                foreach (int item in p_contiene) {
                        MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN en = new MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN ();
                        en.Id = item;
                        iEN.Contiene.Add (en);
                }
        }

        else{
                iEN.Contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
        }

        iEN.UsuarioBloqueado = p_usuarioBloqueado;

        iEN.FechaInicio = p_fechaInicio;

        iEN.FechaFin = p_fechaFin;

        //Call to ICAD

        oid = _IICAD.CrearBloqueo (iEN);
        return oid;
}

public void ModificarBloqueo (int p_i_OID, string p_usuarioBloqueado, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        IEN iEN = null;

        //Initialized IEN
        iEN = new IEN ();
        iEN.Id = p_i_OID;
        iEN.UsuarioBloqueado = p_usuarioBloqueado;
        iEN.FechaInicio = p_fechaInicio;
        iEN.FechaFin = p_fechaFin;
        //Call to ICAD

        _IICAD.ModificarBloqueo (iEN);
}

public void BorrarBloqueo (int id
                           )
{
        _IICAD.BorrarBloqueo (id);
}

public IEN ReadOID (int id
                    )
{
        IEN iEN = null;

        iEN = _IICAD.ReadOID (id);
        return iEN;
}

public System.Collections.Generic.IList<IEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IEN> list = null;

        list = _IICAD.ReadAll (first, size);
        return list;
}
}
}
