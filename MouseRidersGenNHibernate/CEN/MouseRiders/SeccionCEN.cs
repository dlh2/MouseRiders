

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

public int CrearSeccion (string p_nombre)
{
        SeccionEN seccionEN = null;
        int oid;

        //Initialized SeccionEN
        seccionEN = new SeccionEN ();
        seccionEN.Nombre = p_nombre;

        //Call to SeccionCAD

        oid = _ISeccionCAD.CrearSeccion (seccionEN);
        return oid;
}

public void ModificarSeccion (int p_Seccion_OID, string p_nombre)
{
        SeccionEN seccionEN = null;

        //Initialized SeccionEN
        seccionEN = new SeccionEN ();
        seccionEN.Seccion = p_Seccion_OID;
        seccionEN.Nombre = p_nombre;
        //Call to SeccionCAD

        _ISeccionCAD.ModificarSeccion (seccionEN);
}

public void BorrarSeccion (int seccion
                           )
{
        _ISeccionCAD.BorrarSeccion (seccion);
}

public SeccionEN ReadOID (int seccion
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
public MRModel.EN.SeccionEN ReadFilter (string p_nombre)
{
        return _ISeccionCAD.ReadFilter (p_nombre);
}
}
}
