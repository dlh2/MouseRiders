
using System;
// Definición clase ArticuloEN
namespace MRModel.EN
{
public partial class ArticuloEN
{
/**
 *	Atributo pertenece
 */
private MRModel.EN.SeccionEN pertenece;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo autor
 */
private string autor;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo contenidoDescargable
 */
private string contenidoDescargable;



/**
 *	Atributo puntuacion
 */
private float puntuacion;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo tiene
 */
private System.Collections.Generic.IList<MRModel.EN.ComentarioEN> tiene;



/**
 *	Atributo contador
 */
private int contador;



/**
 *	Atributo subtitulo
 */
private string subtitulo;



/**
 *	Atributo portada
 */
private string portada;



/**
 *	Atributo descripcion
 */
private string descripcion;






public virtual MRModel.EN.SeccionEN Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Autor {
        get { return autor; } set { autor = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual string ContenidoDescargable {
        get { return contenidoDescargable; } set { contenidoDescargable = value;  }
}



public virtual float Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.ComentarioEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}



public virtual int Contador {
        get { return contador; } set { contador = value;  }
}



public virtual string Subtitulo {
        get { return subtitulo; } set { subtitulo = value;  }
}



public virtual string Portada {
        get { return portada; } set { portada = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}





public ArticuloEN()
{
        tiene = new System.Collections.Generic.List<MRModel.EN.ComentarioEN>();
}



public ArticuloEN(int id, MRModel.EN.SeccionEN pertenece, string titulo, string autor, string contenido, string contenidoDescargable, float puntuacion, Nullable<DateTime> fecha, System.Collections.Generic.IList<MRModel.EN.ComentarioEN> tiene, int contador, string subtitulo, string portada, string descripcion
                  )
{
        this.init (Id, pertenece, titulo, autor, contenido, contenidoDescargable, puntuacion, fecha, tiene, contador, subtitulo, portada, descripcion);
}


public ArticuloEN(ArticuloEN articulo)
{
        this.init (Id, articulo.Pertenece, articulo.Titulo, articulo.Autor, articulo.Contenido, articulo.ContenidoDescargable, articulo.Puntuacion, articulo.Fecha, articulo.Tiene, articulo.Contador, articulo.Subtitulo, articulo.Portada, articulo.Descripcion);
}

private void init (int id
                   , MRModel.EN.SeccionEN pertenece, string titulo, string autor, string contenido, string contenidoDescargable, float puntuacion, Nullable<DateTime> fecha, System.Collections.Generic.IList<MRModel.EN.ComentarioEN> tiene, int contador, string subtitulo, string portada, string descripcion)
{
        this.Id = id;


        this.Pertenece = pertenece;

        this.Titulo = titulo;

        this.Autor = autor;

        this.Contenido = contenido;

        this.ContenidoDescargable = contenidoDescargable;

        this.Puntuacion = puntuacion;

        this.Fecha = fecha;

        this.Tiene = tiene;

        this.Contador = contador;

        this.Subtitulo = subtitulo;

        this.Portada = portada;

        this.Descripcion = descripcion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ArticuloEN t = obj as ArticuloEN;
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
