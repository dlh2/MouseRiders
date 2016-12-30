
using System;
using MRModel.EN;

namespace MRModel.CAD
{
public partial interface IPermisoCAD
{
PermisoEN ReadOIDDefault (MRModel.EN.PermisoEN_OID permisoEN_OID
                          );

void ModifyDefault (PermisoEN permiso);



MRModel.EN.PermisoEN_OID CrearPermiso (PermisoEN permiso);

void ModificarPermiso (PermisoEN permiso);


void BorrarPermiso (MRModel.EN.PermisoEN_OID permisoEN_OID
                    );


PermisoEN ReadOID (MRModel.EN.PermisoEN_OID permisoEN_OID
                   );


System.Collections.Generic.IList<PermisoEN> ReadAll (int first, int size);


System.Collections.Generic.IList<MRModel.EN.PermisoEN> ReadFilter (MRModel.Enumerated.T_RolEnum? p_rol, string p_permiso);
}
}
