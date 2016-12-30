
using System;
// Definición clase AdministradorEN
namespace MRModel.EN
{
public partial class AdministradorEN                                                                        : MRModel.EN.UsuarioEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(int id,
                       string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MRModel.EN.DenunciaEN> creaD, System.Collections.Generic.IList<MRModel.EN.RecompensaEN> obtiene, System.Collections.Generic.IList<MRModel.EN.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MRModel.EN.MensajeEN> envia, System.Collections.Generic.IList<MRModel.EN.MensajeEN> recibe, MRModel.EN.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MRModel.EN.DenunciaEN> recibeD, string nombreusuario
                       )
{
        this.init (Id, email, nombre, apellidos, pais, telefono, puntuacion, creaD, obtiene, tiene, fechaRegistro, envia, recibe, es_de, contrasenya, recibeD, nombreusuario);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Id, administrador.Email, administrador.Nombre, administrador.Apellidos, administrador.Pais, administrador.Telefono, administrador.Puntuacion, administrador.CreaD, administrador.Obtiene, administrador.Tiene, administrador.FechaRegistro, administrador.Envia, administrador.Recibe, administrador.Es_de, administrador.Contrasenya, administrador.RecibeD, administrador.Nombreusuario);
}

private void init (int id
                   , string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MRModel.EN.DenunciaEN> creaD, System.Collections.Generic.IList<MRModel.EN.RecompensaEN> obtiene, System.Collections.Generic.IList<MRModel.EN.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MRModel.EN.MensajeEN> envia, System.Collections.Generic.IList<MRModel.EN.MensajeEN> recibe, MRModel.EN.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MRModel.EN.DenunciaEN> recibeD, string nombreusuario)
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
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
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
