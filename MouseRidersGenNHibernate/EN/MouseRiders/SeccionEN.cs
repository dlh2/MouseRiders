
using System;
// Definición clase SeccionEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class SeccionEN
{
/**
 *	Atributo tiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> tiene;



/**
 *	Atributo seccion
 */
private int seccion;



/**
 *	Atributo nombre
 */
private string nombre;






public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}



public virtual int Seccion {
        get { return seccion; } set { seccion = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public SeccionEN()
{
        tiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN>();
}



public SeccionEN(int seccion, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> tiene, string nombre
                 )
{
        this.init (Seccion, tiene, nombre);
}


public SeccionEN(SeccionEN seccion)
{
        this.init (Seccion, seccion.Tiene, seccion.Nombre);
}

private void init (int seccion
                   , System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> tiene, string nombre)
{
        this.Seccion = seccion;


        this.Tiene = tiene;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SeccionEN t = obj as SeccionEN;
        if (t == null)
                return false;
        if (Seccion.Equals (t.Seccion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Seccion.GetHashCode ();
        return hash;
}
}
}
