

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
 *      Definition of the class RedactorCEN
 *
 */
public partial class RedactorCEN
{
private IRedactorCAD _IRedactorCAD;

public RedactorCEN()
{
        this._IRedactorCAD = new RedactorCAD ();
}

public RedactorCEN(IRedactorCAD _IRedactorCAD)
{
        this._IRedactorCAD = _IRedactorCAD;
}

public IRedactorCAD get_IRedactorCAD ()
{
        return this._IRedactorCAD;
}

public int CrearRedactor (string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario, string p_fotoperfil)
{
        RedactorEN redactorEN = null;
        int oid;

        //Initialized RedactorEN
        redactorEN = new RedactorEN ();
        redactorEN.Email = p_email;

        redactorEN.Nombre = p_nombre;

        redactorEN.Apellidos = p_apellidos;

        redactorEN.Pais = p_pais;

        redactorEN.Telefono = p_telefono;

        redactorEN.Puntuacion = p_puntuacion;

        redactorEN.FechaRegistro = p_fechaRegistro;

        redactorEN.Contrasenya = p_contrasenya;

        redactorEN.Nombreusuario = p_nombreusuario;

        redactorEN.Fotoperfil = p_fotoperfil;

        //Call to RedactorCAD

        oid = _IRedactorCAD.CrearRedactor (redactorEN);
        return oid;
}

public void ModificarRedactor (int p_Redactor_OID, string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario, string p_fotoperfil)
{
        RedactorEN redactorEN = null;

        //Initialized RedactorEN
        redactorEN = new RedactorEN ();
        redactorEN.Id = p_Redactor_OID;
        redactorEN.Email = p_email;
        redactorEN.Nombre = p_nombre;
        redactorEN.Apellidos = p_apellidos;
        redactorEN.Pais = p_pais;
        redactorEN.Telefono = p_telefono;
        redactorEN.Puntuacion = p_puntuacion;
        redactorEN.FechaRegistro = p_fechaRegistro;
        redactorEN.Contrasenya = p_contrasenya;
        redactorEN.Nombreusuario = p_nombreusuario;
        redactorEN.Fotoperfil = p_fotoperfil;
        //Call to RedactorCAD

        _IRedactorCAD.ModificarRedactor (redactorEN);
}

public void BorrarRedactor (int id
                            )
{
        _IRedactorCAD.BorrarRedactor (id);
}

public RedactorEN ReadOID (int id
                           )
{
        RedactorEN redactorEN = null;

        redactorEN = _IRedactorCAD.ReadOID (id);
        return redactorEN;
}

public System.Collections.Generic.IList<RedactorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RedactorEN> list = null;

        list = _IRedactorCAD.ReadAll (first, size);
        return list;
}
}
}
