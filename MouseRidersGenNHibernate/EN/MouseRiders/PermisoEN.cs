
using System;
// Definición clase PermisoEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public partial class PermisoEN
{
protected MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID;
public virtual PermisoEN_OID PermisoOID {
        get { return permisoEN_OID; } set { permisoEN_OID = value;  }
}




/**
 *	Atributo rol
 */
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum rol;



/**
 *	Atributo permiso
 */
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PermisoEnum permiso;



/**
 *	Atributo permisos
 */
private string permisos;



/**
 *	Atributo pertenece
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> pertenece;










public virtual string Permisos {
        get { return permisos; } set { permisos = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> Pertenece {
        get { return pertenece; } set { pertenece = value;  }
}





public PermisoEN()
{
        permisoEN_OID = new MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID ();



        pertenece = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN>();
}



public PermisoEN(MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID, string permisos, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> pertenece
                 )
{
        this.init (PermisoOID, permisos, pertenece);
}


public PermisoEN(PermisoEN permiso)
{
        this.init (PermisoOID, permiso.Permisos, permiso.Pertenece);
}

private void init (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
                   , string permisos, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> pertenece)
{
        this.PermisoOID = permisoEN_OID;


        this.Permisos = permisos;

        this.Pertenece = pertenece;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PermisoEN t = obj as PermisoEN;
        if (t == null)
                return false;
        if (PermisoOID.Equals (t.PermisoOID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.PermisoOID.GetHashCode ();
        return hash;
}
}
}
