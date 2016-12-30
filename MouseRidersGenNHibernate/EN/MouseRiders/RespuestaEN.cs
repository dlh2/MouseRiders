
using System;
// Definición clase RespuestaEN
namespace MRModel.EN
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
private MRModel.Enumerated.T_PreguntaEnum tipo;



/**
 *	Atributo pertenece
 */
private MRModel.EN.PreguntaEN pertenece;



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



public virtual MRModel.Enumerated.T_PreguntaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual MRModel.EN.PreguntaEN Pertenece {
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



public RespuestaEN(int id, string respuesta, MRModel.Enumerated.T_PreguntaEnum tipo, MRModel.EN.PreguntaEN pertenece, int contador, float frecuencia
                   )
{
        this.init (Id, respuesta, tipo, pertenece, contador, frecuencia);
}


public RespuestaEN(RespuestaEN respuesta)
{
        this.init (Id, respuesta.Respuesta, respuesta.Tipo, respuesta.Pertenece, respuesta.Contador, respuesta.Frecuencia);
}

private void init (int id
                   , string respuesta, MRModel.Enumerated.T_PreguntaEnum tipo, MRModel.EN.PreguntaEN pertenece, int contador, float frecuencia)
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
