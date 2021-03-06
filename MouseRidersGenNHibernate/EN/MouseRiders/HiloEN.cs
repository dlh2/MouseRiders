
using System;
// Definición clase HiloEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class HiloEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo creador
 */
private string creador;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo numComentarios
 */
private int numComentarios;



/**
 *	Atributo contiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN> contiene;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo primerComentario
 */
private string primerComentario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Creador {
        get { return creador; } set { creador = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual int NumComentarios {
        get { return numComentarios; } set { numComentarios = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN> Contiene {
        get { return contiene; } set { contiene = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string PrimerComentario {
        get { return primerComentario; } set { primerComentario = value;  }
}





public HiloEN()
{
        contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN>();
}



public HiloEN(int id, string creador, Nullable<DateTime> fecha, int numComentarios, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN> contiene, string titulo, string primerComentario
              )
{
        this.init (Id, creador, fecha, numComentarios, contiene, titulo, primerComentario);
}


public HiloEN(HiloEN hilo)
{
        this.init (Id, hilo.Creador, hilo.Fecha, hilo.NumComentarios, hilo.Contiene, hilo.Titulo, hilo.PrimerComentario);
}

private void init (int id
                   , string creador, Nullable<DateTime> fecha, int numComentarios, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN> contiene, string titulo, string primerComentario)
{
        this.Id = id;


        this.Creador = creador;

        this.Fecha = fecha;

        this.NumComentarios = numComentarios;

        this.Contiene = contiene;

        this.Titulo = titulo;

        this.PrimerComentario = primerComentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        HiloEN t = obj as HiloEN;
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
