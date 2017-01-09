
using System;
// Definición clase UsuarioEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class UsuarioEN
{
/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo pais
 */
private string pais;



/**
 *	Atributo telefono
 */
private int telefono;



/**
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo creaD
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> creaD;



/**
 *	Atributo obtiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> obtiene;



/**
 *	Atributo tiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> tiene;



/**
 *	Atributo fechaRegistro
 */
private Nullable<DateTime> fechaRegistro;



/**
 *	Atributo envia
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> envia;



/**
 *	Atributo recibe
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> recibe;



/**
 *	Atributo es_de
 */
private MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN es_de;



/**
 *	Atributo contrasenya
 */
private string contrasenya;



/**
 *	Atributo recibeD
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> recibeD;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombreusuario
 */
private string nombreusuario;



/**
 *	Atributo fotoperfil
 */
private string fotoperfil;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Pais {
        get { return pais; } set { pais = value;  }
}



public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> CreaD {
        get { return creaD; } set { creaD = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> Obtiene {
        get { return obtiene; } set { obtiene = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}



public virtual Nullable<DateTime> FechaRegistro {
        get { return fechaRegistro; } set { fechaRegistro = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> Envia {
        get { return envia; } set { envia = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> Recibe {
        get { return recibe; } set { recibe = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN Es_de {
        get { return es_de; } set { es_de = value;  }
}



public virtual string Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> RecibeD {
        get { return recibeD; } set { recibeD = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombreusuario {
        get { return nombreusuario; } set { nombreusuario = value;  }
}



public virtual string Fotoperfil {
        get { return fotoperfil; } set { fotoperfil = value;  }
}





public UsuarioEN()
{
        creaD = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
        obtiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN>();
        tiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN>();
        envia = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN>();
        recibe = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN>();
        recibeD = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
}



public UsuarioEN(int id, string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> creaD, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> obtiene, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> envia, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN> recibe, MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> recibeD, string nombreusuario, string fotoperfil
                 )
{
        this.init (Id, email, nombre, apellidos, pais, telefono, puntuacion, creaD, obtiene, tiene, fechaRegistro, envia, recibe, es_de, contrasenya, recibeD, nombreusuario, fotoperfil);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id, usuario.Email, usuario.Nombre, usuario.Apellidos, usuario.Pais, usuario.Telefono, usuario.Puntuacion, usuario.CreaD, usuario.Obtiene, usuario.Tiene, usuario.FechaRegistro, usuario.Envia, usuario.Recibe, usuario.Es_de, usuario.Contrasenya, usuario.RecibeD, usuario.Nombreusuario, usuario.Fotoperfil);
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
        UsuarioEN t = obj as UsuarioEN;
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
