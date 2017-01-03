
using System;
// Definición clase PreguntaEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class PreguntaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pregunta
 */
private string pregunta;



/**
 *	Atributo tipo
 */
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo;



/**
 *	Atributo pertenece
 */
private MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN pertenece;



/**
 *	Atributo tiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN> tiene;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Pregunta {
        get { return pregunta; } set { pregunta = value;  }
}



public virtual MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}





public PreguntaEN()
{
        tiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN>();
}



public PreguntaEN(int id, string pregunta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo, MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN pertenece, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN> tiene
                  )
{
        this.init (Id, pregunta, tipo, pertenece, tiene);
}


public PreguntaEN(PreguntaEN pregunta)
{
        this.init (Id, pregunta.Pregunta, pregunta.Tipo, pregunta.Pertenece, pregunta.Tiene);
}

private void init (int id
                   , string pregunta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum tipo, MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN pertenece, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RespuestaEN> tiene)
{
        this.Id = id;


        this.Pregunta = pregunta;

        this.Tipo = tipo;

        this.Pertenece = pertenece;

        this.Tiene = tiene;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PreguntaEN t = obj as PreguntaEN;
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
