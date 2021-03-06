
using System;
// Definición clase BloqueoEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class BloqueoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contiene
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> contiene;



/**
 *	Atributo pertenece
 */
private MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN pertenece;



/**
 *	Atributo fechaInicio
 */
private Nullable<DateTime> fechaInicio;



/**
 *	Atributo fechaFin
 */
private Nullable<DateTime> fechaFin;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> Contiene {
        get { return contiene; } set { contiene = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}



public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}



public virtual Nullable<DateTime> FechaFin {
        get { return fechaFin; } set { fechaFin = value;  }
}





public BloqueoEN()
{
        contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
}



public BloqueoEN(int id, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> contiene, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN pertenece, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin
                 )
{
        this.init (Id, contiene, pertenece, fechaInicio, fechaFin);
}


public BloqueoEN(BloqueoEN bloqueo)
{
        this.init (Id, bloqueo.Contiene, bloqueo.Pertenece, bloqueo.FechaInicio, bloqueo.FechaFin);
}

private void init (int id
                   , System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> contiene, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN pertenece, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin)
{
        this.Id = id;


        this.Contiene = contiene;

        this.Pertenece = pertenece;

        this.FechaInicio = fechaInicio;

        this.FechaFin = fechaFin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        BloqueoEN t = obj as BloqueoEN;
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
