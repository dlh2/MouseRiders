
using System;
// Definición clase ForoEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class ForoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.HiloEN> contiene;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.HiloEN> Contiene {
        get { return contiene; } set { contiene = value;  }
}





public ForoEN()
{
        contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.HiloEN>();
}



public ForoEN(int id, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.HiloEN> contiene
              )
{
        this.init (Id, contiene);
}


public ForoEN(ForoEN foro)
{
        this.init (Id, foro.Contiene);
}

private void init (int id
                   , System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.HiloEN> contiene)
{
        this.Id = id;


        this.Contiene = contiene;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ForoEN t = obj as ForoEN;
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
