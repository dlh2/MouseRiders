

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
 *      Definition of the class ControladorNotificacionesCEN
 *
 */
public partial class ControladorNotificacionesCEN
{
private IControladorNotificacionesCAD _IControladorNotificacionesCAD;

public ControladorNotificacionesCEN()
{
        this._IControladorNotificacionesCAD = new ControladorNotificacionesCAD ();
}

public ControladorNotificacionesCEN(IControladorNotificacionesCAD _IControladorNotificacionesCAD)
{
        this._IControladorNotificacionesCAD = _IControladorNotificacionesCAD;
}

public IControladorNotificacionesCAD get_IControladorNotificacionesCAD ()
{
        return this._IControladorNotificacionesCAD;
}

public int CrearCNotificaciones ()
{
        ControladorNotificacionesEN controladorNotificacionesEN = null;
        int oid;

        //Initialized ControladorNotificacionesEN
        controladorNotificacionesEN = new ControladorNotificacionesEN ();
        //Call to ControladorNotificacionesCAD

        oid = _IControladorNotificacionesCAD.CrearCNotificaciones (controladorNotificacionesEN);
        return oid;
}

public void ModificarCNotificaciones (int p_ControladorNotificaciones_OID)
{
        ControladorNotificacionesEN controladorNotificacionesEN = null;

        //Initialized ControladorNotificacionesEN
        controladorNotificacionesEN = new ControladorNotificacionesEN ();
        controladorNotificacionesEN.Id = p_ControladorNotificaciones_OID;
        //Call to ControladorNotificacionesCAD

        _IControladorNotificacionesCAD.ModificarCNotificaciones (controladorNotificacionesEN);
}

public void BorrarCNotificaciones (int id
                                   )
{
        _IControladorNotificacionesCAD.BorrarCNotificaciones (id);
}

public ControladorNotificacionesEN ReadOID (int id
                                            )
{
        ControladorNotificacionesEN controladorNotificacionesEN = null;

        controladorNotificacionesEN = _IControladorNotificacionesCAD.ReadOID (id);
        return controladorNotificacionesEN;
}

public System.Collections.Generic.IList<ControladorNotificacionesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ControladorNotificacionesEN> list = null;

        list = _IControladorNotificacionesCAD.ReadAll (first, size);
        return list;
}
}
}
