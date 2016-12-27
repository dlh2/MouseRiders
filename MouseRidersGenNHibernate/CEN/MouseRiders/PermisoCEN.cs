

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
 *      Definition of the class PermisoCEN
 *
 */
public partial class PermisoCEN
{
private IPermisoCAD _IPermisoCAD;

public PermisoCEN()
{
        this._IPermisoCAD = new PermisoCAD ();
}

public PermisoCEN(IPermisoCAD _IPermisoCAD)
{
        this._IPermisoCAD = _IPermisoCAD;
}

public IPermisoCAD get_IPermisoCAD ()
{
        return this._IPermisoCAD;
}

public MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID CrearPermiso (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum p_rol, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PermisoEnum p_permiso, string p_permisos)
{
        PermisoEN permisoEN = null;

        MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID oid;
        //Initialized PermisoEN
        permisoEN = new PermisoEN ();
        permisoEN.PermisoOID = new MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID ();
        permisoEN.PermisoOID.Rol = p_rol;

        permisoEN.PermisoOID.Permiso = p_permiso;

        permisoEN.Permisos = p_permisos;

        //Call to PermisoCAD

        oid = _IPermisoCAD.CrearPermiso (permisoEN);
        return oid;
}

public void ModificarPermiso (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID p_Permiso_OID, string p_permisos)
{
        PermisoEN permisoEN = null;

        //Initialized PermisoEN
        permisoEN = new PermisoEN ();
        permisoEN.PermisoOID = p_Permiso_OID;
        permisoEN.Permisos = p_permisos;
        //Call to PermisoCAD

        _IPermisoCAD.ModificarPermiso (permisoEN);
}

public void BorrarPermiso (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
                           )
{
        _IPermisoCAD.BorrarPermiso (permisoEN_OID);
}

public PermisoEN ReadOID (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
                          )
{
        PermisoEN permisoEN = null;

        permisoEN = _IPermisoCAD.ReadOID (permisoEN_OID);
        return permisoEN;
}

public System.Collections.Generic.IList<PermisoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PermisoEN> list = null;

        list = _IPermisoCAD.ReadAll (first, size);
        return list;
}
}
}
