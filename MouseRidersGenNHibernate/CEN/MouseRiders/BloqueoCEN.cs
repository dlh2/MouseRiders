

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
 *      Definition of the class BloqueoCEN
 *
 */
public partial class BloqueoCEN
{
private IBloqueoCAD _IBloqueoCAD;

public BloqueoCEN()
{
        this._IBloqueoCAD = new BloqueoCAD ();
}

public BloqueoCEN(IBloqueoCAD _IBloqueoCAD)
{
        this._IBloqueoCAD = _IBloqueoCAD;
}

public IBloqueoCAD get_IBloqueoCAD ()
{
        return this._IBloqueoCAD;
}

public int CrearBloqueo (System.Collections.Generic.IList<int> p_contiene, int p_pertenece, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        BloqueoEN bloqueoEN = null;
        int oid;

        //Initialized BloqueoEN
        bloqueoEN = new BloqueoEN ();

        bloqueoEN.Contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
        if (p_contiene != null) {
                foreach (int item in p_contiene) {
                        MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN en = new MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN ();
                        en.Id = item;
                        bloqueoEN.Contiene.Add (en);
                }
        }

        else{
                bloqueoEN.Contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
        }


        if (p_pertenece != -1) {
                // El argumento p_pertenece -> Property pertenece es oid = false
                // Lista de oids id
                bloqueoEN.Pertenece = new MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN ();
                bloqueoEN.Pertenece.Id = p_pertenece;
        }

        bloqueoEN.FechaInicio = p_fechaInicio;

        bloqueoEN.FechaFin = p_fechaFin;

        //Call to BloqueoCAD

        oid = _IBloqueoCAD.CrearBloqueo (bloqueoEN);
        return oid;
}

public void ModificarBloqueo (int p_Bloqueo_OID, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        BloqueoEN bloqueoEN = null;

        //Initialized BloqueoEN
        bloqueoEN = new BloqueoEN ();
        bloqueoEN.Id = p_Bloqueo_OID;
        bloqueoEN.FechaInicio = p_fechaInicio;
        bloqueoEN.FechaFin = p_fechaFin;
        //Call to BloqueoCAD

        _IBloqueoCAD.ModificarBloqueo (bloqueoEN);
}

public void BorrarBloqueo (int id
                           )
{
        _IBloqueoCAD.BorrarBloqueo (id);
}

public BloqueoEN ReadOID (int id
                          )
{
        BloqueoEN bloqueoEN = null;

        bloqueoEN = _IBloqueoCAD.ReadOID (id);
        return bloqueoEN;
}

public System.Collections.Generic.IList<BloqueoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<BloqueoEN> list = null;

        list = _IBloqueoCAD.ReadAll (first, size);
        return list;
}
}
}
