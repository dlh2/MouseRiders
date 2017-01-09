using System;
using System.Collections.Generic;
namespace MouseRidersGenNHibernate.EN.MouseRiders
{
public class PermisoEN_OID
{
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum rol;
public virtual MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum Rol {
        get { return rol; } set { rol = value;  }
}




private string permiso;
public virtual string Permiso {
        get { return permiso; } set { permiso = value;  }
}






public PermisoEN_OID()
{
}
public PermisoEN_OID(MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum rol, string permiso)
{
        this.rol = rol;
        this.permiso = permiso;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PermisoEN_OID t = obj as PermisoEN_OID;
        if (t == null)
                return false;


        if (this.rol == t.Rol && this.permiso == t.Permiso)

                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        // Su tipo es Enum
        hash = hash +this.rol.GetHashCode ();
        // Su tipo es String
        hash = hash +
               (null == permiso                                                  ? 0 : this.permiso.GetHashCode ());
        return hash;
}
}
}
