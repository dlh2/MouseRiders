

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
 *      Definition of the class Admin_foroCEN
 *
 */
public partial class Admin_foroCEN
{
private IAdmin_foroCAD _IAdmin_foroCAD;

public Admin_foroCEN()
{
        this._IAdmin_foroCAD = new Admin_foroCAD ();
}

public Admin_foroCEN(IAdmin_foroCAD _IAdmin_foroCAD)
{
        this._IAdmin_foroCAD = _IAdmin_foroCAD;
}

public IAdmin_foroCAD get_IAdmin_foroCAD ()
{
        return this._IAdmin_foroCAD;
}

public int CrearAdmin_foro (string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario, string p_fotoperfil)
{
        Admin_foroEN admin_foroEN = null;
        int oid;

        //Initialized Admin_foroEN
        admin_foroEN = new Admin_foroEN ();
        admin_foroEN.Email = p_email;

        admin_foroEN.Nombre = p_nombre;

        admin_foroEN.Apellidos = p_apellidos;

        admin_foroEN.Pais = p_pais;

        admin_foroEN.Telefono = p_telefono;

        admin_foroEN.Puntuacion = p_puntuacion;

        admin_foroEN.FechaRegistro = p_fechaRegistro;

        admin_foroEN.Contrasenya = p_contrasenya;

        admin_foroEN.Nombreusuario = p_nombreusuario;

        admin_foroEN.Fotoperfil = p_fotoperfil;

        //Call to Admin_foroCAD

        oid = _IAdmin_foroCAD.CrearAdmin_foro (admin_foroEN);
        return oid;
}

public void ModificarAdmin_foro (int p_Admin_foro_OID, string p_email, string p_nombre, string p_apellidos, string p_pais, int p_telefono, int p_puntuacion, Nullable<DateTime> p_fechaRegistro, string p_contrasenya, string p_nombreusuario, string p_fotoperfil)
{
        Admin_foroEN admin_foroEN = null;

        //Initialized Admin_foroEN
        admin_foroEN = new Admin_foroEN ();
        admin_foroEN.Id = p_Admin_foro_OID;
        admin_foroEN.Email = p_email;
        admin_foroEN.Nombre = p_nombre;
        admin_foroEN.Apellidos = p_apellidos;
        admin_foroEN.Pais = p_pais;
        admin_foroEN.Telefono = p_telefono;
        admin_foroEN.Puntuacion = p_puntuacion;
        admin_foroEN.FechaRegistro = p_fechaRegistro;
        admin_foroEN.Contrasenya = p_contrasenya;
        admin_foroEN.Nombreusuario = p_nombreusuario;
        admin_foroEN.Fotoperfil = p_fotoperfil;
        //Call to Admin_foroCAD

        _IAdmin_foroCAD.ModificarAdmin_foro (admin_foroEN);
}

public void BorrarAdmin_foro (int id
                              )
{
        _IAdmin_foroCAD.BorrarAdmin_foro (id);
}

public Admin_foroEN ReadOID (int id
                             )
{
        Admin_foroEN admin_foroEN = null;

        admin_foroEN = _IAdmin_foroCAD.ReadOID (id);
        return admin_foroEN;
}

public System.Collections.Generic.IList<Admin_foroEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Admin_foroEN> list = null;

        list = _IAdmin_foroCAD.ReadAll (first, size);
        return list;
}
}
}
