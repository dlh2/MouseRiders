

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
 *      Definition of the class AdministradorCEN
 *
 */
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public int CrearAdministrador (string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario)
{
        AdministradorEN administradorEN = null;
        int oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Email = p_email;

        administradorEN.Nombre = p_nombre;

        administradorEN.Apellidos = p_apellidos;

        administradorEN.Pais = p_pais;

        administradorEN.Telefono = p_telefono;

        administradorEN.Puntuacion = p_puntuacion;

        administradorEN.FechaRegistro = p_fechaRegistro;

        administradorEN.Contrasenya = p_contrasenya;

        administradorEN.Nombreusuario = p_nombreusuario;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.CrearAdministrador (administradorEN);
        return oid;
}

public void ModificarAdministrador (int p_Administrador_OID, string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Id = p_Administrador_OID;
        administradorEN.Email = p_email;
        administradorEN.Nombre = p_nombre;
        administradorEN.Apellidos = p_apellidos;
        administradorEN.Pais = p_pais;
        administradorEN.Telefono = p_telefono;
        administradorEN.Puntuacion = p_puntuacion;
        administradorEN.FechaRegistro = p_fechaRegistro;
        administradorEN.Contrasenya = p_contrasenya;
        administradorEN.Nombreusuario = p_nombreusuario;
        //Call to AdministradorCAD

        _IAdministradorCAD.ModificarAdministrador (administradorEN);
}

public void BorrarAdministrador (int id
                                 )
{
        _IAdministradorCAD.BorrarAdministrador (id);
}

public AdministradorEN ReadOID (int id
                                )
{
        AdministradorEN administradorEN = null;

        administradorEN = _IAdministradorCAD.ReadOID (id);
        return administradorEN;
}

public System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministradorEN> list = null;

        list = _IAdministradorCAD.ReadAll (first, size);
        return list;
}
}
}
