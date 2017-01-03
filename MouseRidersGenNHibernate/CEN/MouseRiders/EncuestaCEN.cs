

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
 *      Definition of the class EncuestaCEN
 *
 */
public partial class EncuestaCEN
{
private IEncuestaCAD _IEncuestaCAD;

public EncuestaCEN()
{
        this._IEncuestaCAD = new EncuestaCAD ();
}

public EncuestaCEN(IEncuestaCAD _IEncuestaCAD)
{
        this._IEncuestaCAD = _IEncuestaCAD;
}

public IEncuestaCAD get_IEncuestaCAD ()
{
        return this._IEncuestaCAD;
}

public int CrearEncuesta (string p_titulo, string p_descripcion, bool p_privada)
{
        EncuestaEN encuestaEN = null;
        int oid;

        //Initialized EncuestaEN
        encuestaEN = new EncuestaEN ();
        encuestaEN.Titulo = p_titulo;

        encuestaEN.Descripcion = p_descripcion;

        encuestaEN.Privada = p_privada;

        //Call to EncuestaCAD

        oid = _IEncuestaCAD.CrearEncuesta (encuestaEN);
        return oid;
}

public void ModificarEncuesta (int p_Encuesta_OID, string p_titulo, string p_descripcion, bool p_privada)
{
        EncuestaEN encuestaEN = null;

        //Initialized EncuestaEN
        encuestaEN = new EncuestaEN ();
        encuestaEN.Id = p_Encuesta_OID;
        encuestaEN.Titulo = p_titulo;
        encuestaEN.Descripcion = p_descripcion;
        encuestaEN.Privada = p_privada;
        //Call to EncuestaCAD

        _IEncuestaCAD.ModificarEncuesta (encuestaEN);
}

public void BorrarEncuesta (int id
                            )
{
        _IEncuestaCAD.BorrarEncuesta (id);
}

public EncuestaEN ReadOID (int id
                           )
{
        EncuestaEN encuestaEN = null;

        encuestaEN = _IEncuestaCAD.ReadOID (id);
        return encuestaEN;
}

public System.Collections.Generic.IList<EncuestaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EncuestaEN> list = null;

        list = _IEncuestaCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN> ReadFilter (string p_titulo)
{
        return _IEncuestaCAD.ReadFilter (p_titulo);
}
}
}
