
using System;
// Definición clase Admin_foroEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class Admin_foroEN                                                                   : MouseRidersGenNHibernate.EN.MouseRiders.AdministradorEN


{
public Admin_foroEN() : base ()
{
}



public Admin_foroEN(int id,

                    string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> creaD, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> obtiene, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> envia, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> recibe, MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> recibeD, string nombreusuario, string fotoperfil
                    )
{
        this.init (Id, email, nombre, apellidos, pais, telefono, puntuacion, creaD, obtiene, tiene, fechaRegistro, envia, recibe, es_de, contrasenya, recibeD, nombreusuario, fotoperfil);
}


public Admin_foroEN(Admin_foroEN admin_foro)
{
        this.init (Id, admin_foro.Email, admin_foro.Nombre, admin_foro.Apellidos, admin_foro.Pais, admin_foro.Telefono, admin_foro.Puntuacion, admin_foro.CreaD, admin_foro.Obtiene, admin_foro.Tiene, admin_foro.FechaRegistro, admin_foro.Envia, admin_foro.Recibe, admin_foro.Es_de, admin_foro.Contrasenya, admin_foro.RecibeD, admin_foro.Nombreusuario, admin_foro.Fotoperfil);
}

private void init (int id
                   , string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> creaD, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> obtiene, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> envia, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> recibe, MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> recibeD, string nombreusuario, string fotoperfil)
{
        this.Id = id;


        this.Email = email;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Pais = pais;

        this.Telefono = telefono;

        this.Puntuacion = puntuacion;

        this.CreaD = creaD;

        this.Obtiene = obtiene;

        this.Tiene = tiene;

        this.FechaRegistro = fechaRegistro;

        this.Envia = envia;

        this.Recibe = recibe;

        this.Es_de = es_de;

        this.Contrasenya = contrasenya;

        this.RecibeD = recibeD;

        this.Nombreusuario = nombreusuario;

        this.Fotoperfil = fotoperfil;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Admin_foroEN t = obj as Admin_foroEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
