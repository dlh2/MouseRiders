
using System;
// Definición clase RedactorEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class RedactorEN                                                                     : MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN


{
public RedactorEN() : base ()
{
}



public RedactorEN(int id,
                  string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> creaD, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> obtiene, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> envia, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> recibe, MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> recibeD, string nombreusuario, string fotoperfil
                  )
{
        this.init (Id, email, nombre, apellidos, pais, telefono, puntuacion, creaD, obtiene, tiene, fechaRegistro, envia, recibe, es_de, contrasenya, recibeD, nombreusuario, fotoperfil);
}


public RedactorEN(RedactorEN redactor)
{
        this.init (Id, redactor.Email, redactor.Nombre, redactor.Apellidos, redactor.Pais, redactor.Telefono, redactor.Puntuacion, redactor.CreaD, redactor.Obtiene, redactor.Tiene, redactor.FechaRegistro, redactor.Envia, redactor.Recibe, redactor.Es_de, redactor.Contrasenya, redactor.RecibeD, redactor.Nombreusuario, redactor.Fotoperfil);
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
        RedactorEN t = obj as RedactorEN;
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
