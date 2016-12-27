
using System;
// Definición clase DenunciaEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class DenunciaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo motivo
 */
private string motivo;



/**
 *	Atributo pertenece
 */
private MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN pertenece;



/**
 *	Atributo es_creada
 */
private MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_creada;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo es_recibida
 */
private MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_recibida;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN Es_creada {
        get { return es_creada; } set { es_creada = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN Es_recibida {
        get { return es_recibida; } set { es_recibida = value;  }
}





public DenunciaEN()
{
}



public DenunciaEN(int id, string motivo, MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN pertenece, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_creada, Nullable<DateTime> fecha, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_recibida
                  )
{
        this.init (Id, motivo, pertenece, es_creada, fecha, es_recibida);
}


public DenunciaEN(DenunciaEN denuncia)
{
        this.init (Id, denuncia.Motivo, denuncia.Pertenece, denuncia.Es_creada, denuncia.Fecha, denuncia.Es_recibida);
}

private void init (int id
                   , string motivo, MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN pertenece, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_creada, Nullable<DateTime> fecha, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_recibida)
{
        this.Id = id;


        this.Motivo = motivo;

        this.Pertenece = pertenece;

        this.Es_creada = es_creada;

        this.Fecha = fecha;

        this.Es_recibida = es_recibida;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DenunciaEN t = obj as DenunciaEN;
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
