
using System;
// Definición clase RecompensaEN
namespace MRModel.EN
{
public partial class RecompensaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo otorgada
 */
private System.Collections.Generic.IList<MRModel.EN.UsuarioEN> otorgada;



/**
 *	Atributo puntuacion
 */
private int puntuacion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.UsuarioEN> Otorgada {
        get { return otorgada; } set { otorgada = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}





public RecompensaEN()
{
        otorgada = new System.Collections.Generic.List<MRModel.EN.UsuarioEN>();
}



public RecompensaEN(int id, string nombre, string descripcion, System.Collections.Generic.IList<MRModel.EN.UsuarioEN> otorgada, int puntuacion
                    )
{
        this.init (Id, nombre, descripcion, otorgada, puntuacion);
}


public RecompensaEN(RecompensaEN recompensa)
{
        this.init (Id, recompensa.Nombre, recompensa.Descripcion, recompensa.Otorgada, recompensa.Puntuacion);
}

private void init (int id
                   , string nombre, string descripcion, System.Collections.Generic.IList<MRModel.EN.UsuarioEN> otorgada, int puntuacion)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Otorgada = otorgada;

        this.Puntuacion = puntuacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RecompensaEN t = obj as RecompensaEN;
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
