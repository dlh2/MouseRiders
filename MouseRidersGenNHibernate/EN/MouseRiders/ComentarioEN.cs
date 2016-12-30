
using System;
// Definición clase ComentarioEN
namespace MRModel.EN
{
public partial class ComentarioEN
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
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo valoracion
 */
private int valoracion;



/**
 *	Atributo pertenece
 */
private MRModel.EN.ArticuloEN pertenece;



/**
 *	Atributo pertenece_a
 */
private MRModel.EN.HiloEN pertenece_a;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Creador {
        get { return creador; } set { creador = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual int Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual MRModel.EN.ArticuloEN Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}



public virtual MRModel.EN.HiloEN Pertenece_a {
        get { return pertenece_a; } set { pertenece_a = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int id, string creador, Nullable<DateTime> fecha, string contenido, int valoracion, MRModel.EN.ArticuloEN pertenece, MRModel.EN.HiloEN pertenece_a
                    )
{
        this.init (Id, creador, fecha, contenido, valoracion, pertenece, pertenece_a);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Creador, comentario.Fecha, comentario.Contenido, comentario.Valoracion, comentario.Pertenece, comentario.Pertenece_a);
}

private void init (int id
                   , string creador, Nullable<DateTime> fecha, string contenido, int valoracion, MRModel.EN.ArticuloEN pertenece, MRModel.EN.HiloEN pertenece_a)
{
        this.Id = id;


        this.Creador = creador;

        this.Fecha = fecha;

        this.Contenido = contenido;

        this.Valoracion = valoracion;

        this.Pertenece = pertenece;

        this.Pertenece_a = pertenece_a;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
