
using System;
// Definición clase ControladorEncuestaEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class ControladorEncuestaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo lee
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN> lee;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN> Lee {
        get { return lee; } set { lee = value;  }
}





public ControladorEncuestaEN()
{
        lee = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN>();
}



public ControladorEncuestaEN(int id, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN> lee
                             )
{
        this.init (Id, lee);
}


public ControladorEncuestaEN(ControladorEncuestaEN controladorEncuesta)
{
        this.init (Id, controladorEncuesta.Lee);
}

private void init (int id
                   , System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN> lee)
{
        this.Id = id;


        this.Lee = lee;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ControladorEncuestaEN t = obj as ControladorEncuestaEN;
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
