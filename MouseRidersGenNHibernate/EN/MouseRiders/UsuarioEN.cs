
using System;
// Definición clase UsuarioEN
namespace MRModel.EN
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
private System.Collections.Generic.IList<MRModel.EN.DenunciaEN> creaD;



/**
 *	Atributo obtiene
 */
private System.Collections.Generic.IList<MRModel.EN.RecompensaEN> obtiene;



/**
 *	Atributo tiene
 */
private System.Collections.Generic.IList<MRModel.EN.PermisoEN> tiene;



/**
 *	Atributo fechaRegistro
 */
private Nullable<DateTime> fechaRegistro;



/**
 *	Atributo envia
 */
private System.Collections.Generic.IList<MRModel.EN.MensajeEN> envia;



/**
 *	Atributo recibe
 */
private System.Collections.Generic.IList<MRModel.EN.MensajeEN> recibe;



/**
 *	Atributo es_de
 */
private MRModel.EN.BloqueoEN es_de;



/**
 *	Atributo contrasenya
 */
private string contrasenya;



/**
 *	Atributo recibeD
 */
private System.Collections.Generic.IList<MRModel.EN.DenunciaEN> recibeD;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombreusuario
 */
private string nombreusuario;






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



public virtual System.Collections.Generic.IList<MRModel.EN.DenunciaEN> CreaD {
        get { return creaD; } set { creaD = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.RecompensaEN> Obtiene {
        get { return obtiene; } set { obtiene = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.PermisoEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}



public virtual Nullable<DateTime> FechaRegistro {
        get { return fechaRegistro; } set { fechaRegistro = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.MensajeEN> Envia {
        get { return envia; } set { envia = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.MensajeEN> Recibe {
        get { return recibe; } set { recibe = value;  }
}



public virtual MRModel.EN.BloqueoEN Es_de {
        get { return es_de; } set { es_de = value;  }
}



public virtual string Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.DenunciaEN> RecibeD {
        get { return recibeD; } set { recibeD = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombreusuario {
        get { return nombreusuario; } set { nombreusuario = value;  }
}





public UsuarioEN()
{
        creaD = new System.Collections.Generic.List<MRModel.EN.DenunciaEN>();
        obtiene = new System.Collections.Generic.List<MRModel.EN.RecompensaEN>();
        tiene = new System.Collections.Generic.List<MRModel.EN.PermisoEN>();
        envia = new System.Collections.Generic.List<MRModel.EN.MensajeEN>();
        recibe = new System.Collections.Generic.List<MRModel.EN.MensajeEN>();
        recibeD = new System.Collections.Generic.List<MRModel.EN.DenunciaEN>();
}



public UsuarioEN(int id, string email, string nombre, string apellidos, string pais, int telefono, int puntuacion, System.Collections.Generic.IList<MRModel.EN.DenunciaEN> creaD, System.Collections.Generic.IList<MRModel.EN.RecompensaEN> obtiene, System.Collections.Generic.IList<MRModel.EN.PermisoEN> tiene, Nullable<DateTime> fechaRegistro, System.Collections.Generic.IList<MRModel.EN.MensajeEN> envia, System.Collections.Generic.IList<MRModel.EN.MensajeEN> recibe, MRModel.EN.BloqueoEN es_de, string contrasenya, System.Collections.Generic.IList<MRModel.EN.DenunciaEN> recibeD, string nombreusuario
                 )
{
        this.init (Id, email, nombre, apellidos, pais, telefono, puntuacion, creaD, obtiene, tiene, fechaRegistro, envia, recibe, es_de, contrasenya, recibeD, nombreusuario);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id, usuario.Email, usuario.Nombre, usuario.Apellidos, usuario.Pais, usuario.Telefono, usuario.Puntuacion, usuario.CreaD, usuario.Obtiene, usuario.Tiene, usuario.FechaRegistro, usuario.Envia, usuario.Recibe, usuario.Es_de, usuario.Contrasenya, usuario.RecibeD, usuario.Nombreusuario);
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
