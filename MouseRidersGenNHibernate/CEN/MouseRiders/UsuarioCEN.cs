

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int CrearUsuario (string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, int p_id, string p_nombreusuario)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_email;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Pais = p_pais;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Puntuacion = p_puntuacion;

        usuarioEN.FechaRegistro = p_fechaRegistro;

        usuarioEN.Contrasenya = p_contrasenya;

        usuarioEN.Id = p_id;

        usuarioEN.Nombreusuario = p_nombreusuario;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public void ModificarUsuario (int p_Usuario_OID, string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Email = p_email;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Pais = p_pais;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Puntuacion = p_puntuacion;
        usuarioEN.FechaRegistro = p_fechaRegistro;
        usuarioEN.Contrasenya = p_contrasenya;
        usuarioEN.Nombreusuario = p_nombreusuario;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarUsuario (usuarioEN);
}

public void BorrarUsuario (int id
                           )
{
        _IUsuarioCAD.BorrarUsuario (id);
}

public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
public void RelacionaPermiso (int p_Usuario_OID, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID> p_tiene_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.RelacionaPermiso (p_Usuario_OID, p_tiene_OIDs);
}
public void RelacionaRecompensa (int p_Usuario_OID, System.Collections.Generic.IList<int> p_obtiene_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.RelacionaRecompensa (p_Usuario_OID, p_obtiene_OIDs);
}
public void RelacionaDenuncia (int p_Usuario_OID, System.Collections.Generic.IList<int> p_creaD_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.RelacionaDenuncia (p_Usuario_OID, p_creaD_OIDs);
}
public void RelacionaBloqueo (int p_Usuario_OID, int p_es_de_OID)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.RelacionaBloqueo (p_Usuario_OID, p_es_de_OID);
}
}
}
