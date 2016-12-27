
using System;
// Definición clase RespuestaEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class RespuestaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo respuesta
 */
private string respuesta;



/**
 *	Atributo tipo
 */
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo;



/**
 *	Atributo pertenece
 */
private MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN pertenece;



/**
 *	Atributo contador
 */
private int contador;



/**
 *	Atributo frecuencia
 */
private float frecuencia;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Respuesta {
        get { return respuesta; } set { respuesta = value;  }
}



public virtual MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}



public virtual int Contador {
        get { return contador; } set { contador = value;  }
}



public virtual float Frecuencia {
        get { return frecuencia; } set { frecuencia = value;  }
}





public RespuestaEN()
{
}



public RespuestaEN(int id, string respuesta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo, MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN pertenece, int contador, float frecuencia
                   )
{
        this.init (Id, respuesta, tipo, pertenece, contador, frecuencia);
}


public RespuestaEN(RespuestaEN respuesta)
{
        this.init (Id, respuesta.Respuesta, respuesta.Tipo, respuesta.Pertenece, respuesta.Contador, respuesta.Frecuencia);
}

private void init (int id
                   , string respuesta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo, MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN pertenece, int contador, float frecuencia)
{
        this.Id = id;


        this.Respuesta = respuesta;

        this.Tipo = tipo;

        this.Pertenece = pertenece;

        this.Contador = contador;

        this.Frecuencia = frecuencia;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RespuestaEN t = obj as RespuestaEN;
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
