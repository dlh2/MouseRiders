
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IPermisoCAD
{
PermisoEN ReadOIDDefault (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
                          );

void ModifyDefault (PermisoEN permiso);



MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID CrearPermiso (PermisoEN permiso);

void ModificarPermiso (PermisoEN permiso);


void BorrarPermiso (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
                    );


PermisoEN ReadOID (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
                   );


System.Collections.Generic.IList<PermisoEN> ReadAll (int first, int size);


System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> ReadFilter (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum? p_rol, string p_permiso);
}
}
