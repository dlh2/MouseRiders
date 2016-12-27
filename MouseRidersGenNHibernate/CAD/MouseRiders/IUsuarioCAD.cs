
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int id
                          );

void ModifyDefault (UsuarioEN usuario);



int CrearUsuario (UsuarioEN usuario);

void ModificarUsuario (UsuarioEN usuario);


void BorrarUsuario (int id
                    );






UsuarioEN ReadOID (int id
                   );


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);


void RelacionaPermiso (int p_Usuario_OID, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID> p_tiene_OIDs);

void RelacionaRecompensa (int p_Usuario_OID, System.Collections.Generic.IList<int> p_obtiene_OIDs);

void RelacionaDenuncia (int p_Usuario_OID, System.Collections.Generic.IList<int> p_creaD_OIDs);

void RelacionaBloqueo (int p_Usuario_OID, int p_es_de_OID);
}
}
