
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
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion;






public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> Tiene {
        get { return tiene; } set { tiene = value;  }
}



public virtual MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum Seccion {
        get { return seccion; } set { seccion = value;  }
}





public SeccionEN()
{
        tiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN>();
}



public SeccionEN(MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> tiene
                 )
{
        this.init (Seccion, tiene);
}


public SeccionEN(SeccionEN seccion)
{
        this.init (Seccion, seccion.Tiene);
}

private void init (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                   , System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> tiene)
{
        this.Seccion = seccion;


        this.Tiene = tiene;
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
