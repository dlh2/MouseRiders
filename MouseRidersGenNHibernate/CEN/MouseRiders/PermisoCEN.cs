

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MRModel.Exceptions;

using MRModel.EN;
using MRModel.CAD;


namespace MRModel.CEN
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

public MRModel.EN.PermisoEN_OID CrearPermiso (MRModel.Enumerated.T_RolEnum p_rol, string p_permiso, string p_permisos)
{
        PermisoEN permisoEN = null;

        MRModel.EN.PermisoEN_OID oid;
        //Initialized PermisoEN
        permisoEN = new PermisoEN ();
        permisoEN.PermisoOID = new MRModel.EN.PermisoEN_OID ();
        permisoEN.PermisoOID.Rol = p_rol;

        permisoEN.PermisoOID.Permiso = p_permiso;

        permisoEN.Permisos = p_permisos;

        //Call to PermisoCAD

        oid = _IPermisoCAD.CrearPermiso (permisoEN);
        return oid;
}

public void ModificarPermiso (MRModel.EN.PermisoEN_OID p_Permiso_OID, string p_permisos)
{
        PermisoEN permisoEN = null;

        //Initialized PermisoEN
        permisoEN = new PermisoEN ();
        permisoEN.PermisoOID = p_Permiso_OID;
        permisoEN.Permisos = p_permisos;
        //Call to PermisoCAD

        _IPermisoCAD.ModificarPermiso (permisoEN);
}

public void BorrarPermiso (MRModel.EN.PermisoEN_OID permisoEN_OID
                           )
{
        _IPermisoCAD.BorrarPermiso (permisoEN_OID);
}

public PermisoEN ReadOID (MRModel.EN.PermisoEN_OID permisoEN_OID
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
public System.Collections.Generic.IList<MRModel.EN.PermisoEN> ReadFilter (MRModel.Enumerated.T_RolEnum? p_rol, string p_permiso)
{
        return _IPermisoCAD.ReadFilter (p_rol, p_permiso);
}
}
}
