
using System;
// Definición clase EncuestaEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class EncuestaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo tiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN> tiene;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}





public EncuestaEN()
{
        tiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN>();
}



public EncuestaEN(int id, string titulo, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN> tiene
                  )
{
        this.init (Id, titulo, tiene);
}


public EncuestaEN(EncuestaEN encuesta)
{
        this.init (Id, encuesta.Titulo, encuesta.Tiene);
}

private void init (int id
                   , string titulo, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN> tiene)
{
        this.Id = id;


        this.Titulo = titulo;

        this.Tiene = tiene;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EncuestaEN t = obj as EncuestaEN;
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
