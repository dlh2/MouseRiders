
using System;
// Definición clase IEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class IEN
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
 *	Atributo usuarioBloqueado
 */
private string usuarioBloqueado;



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



public virtual string UsuarioBloqueado {
        get { return usuarioBloqueado; } set { usuarioBloqueado = value;  }
}



public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}



public virtual Nullable<DateTime> FechaFin {
        get { return fechaFin; } set { fechaFin = value;  }
}





public IEN()
{
        contiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
}



public IEN(int id, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> contiene, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN pertenece, string usuarioBloqueado, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin
           )
{
        this.init (Id, contiene, pertenece, usuarioBloqueado, fechaInicio, fechaFin);
}


public IEN(IEN i)
{
        this.init (Id, i.Contiene, i.Pertenece, i.UsuarioBloqueado, i.FechaInicio, i.FechaFin);
}

private void init (int id
                   , System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN> contiene, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN pertenece, string usuarioBloqueado, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin)
{
        this.Id = id;


        this.Contiene = contiene;

        this.Pertenece = pertenece;

        this.UsuarioBloqueado = usuarioBloqueado;

        this.FechaInicio = fechaInicio;

        this.FechaFin = fechaFin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IEN t = obj as IEN;
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
