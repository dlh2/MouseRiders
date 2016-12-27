
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (int id
                                );

void ModifyDefault (AdministradorEN administrador);



int CrearAdministrador (AdministradorEN administrador);

void ModificarAdministrador (AdministradorEN administrador);


void BorrarAdministrador (int id
                          );



AdministradorEN ReadOID (int id
                         );


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}
