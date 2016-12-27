

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
 *      Definition of the class SeccionCEN
 *
 */
public partial class SeccionCEN
{
private ISeccionCAD _ISeccionCAD;

public SeccionCEN()
{
        this._ISeccionCAD = new SeccionCAD ();
}

public SeccionCEN(ISeccionCAD _ISeccionCAD)
{
        this._ISeccionCAD = _ISeccionCAD;
}

public ISeccionCAD get_ISeccionCAD ()
{
        return this._ISeccionCAD;
}

public MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum CrearSeccion (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum p_seccion)
{
        SeccionEN seccionEN = null;

        MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum oid;
        //Initialized SeccionEN
        seccionEN = new SeccionEN ();
        seccionEN.Seccion = p_seccion;

        //Call to SeccionCAD

        oid = _ISeccionCAD.CrearSeccion (seccionEN);
        return oid;
}

public void ModificarSeccion (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum p_Seccion_OID)
{
        SeccionEN seccionEN = null;

        //Initialized SeccionEN
        seccionEN = new SeccionEN ();
        seccionEN.Seccion = p_Seccion_OID;
        //Call to SeccionCAD

        _ISeccionCAD.ModificarSeccion (seccionEN);
}

public void BorrarSeccion (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                           )
{
        _ISeccionCAD.BorrarSeccion (seccion);
}

public SeccionEN ReadOID (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                          )
{
        SeccionEN seccionEN = null;

        seccionEN = _ISeccionCAD.ReadOID (seccion);
        return seccionEN;
}

public System.Collections.Generic.IList<SeccionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SeccionEN> list = null;

        list = _ISeccionCAD.ReadAll (first, size);
        return list;
}
}
}
