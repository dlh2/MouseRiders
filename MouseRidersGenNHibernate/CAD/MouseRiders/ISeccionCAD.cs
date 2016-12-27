
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface ISeccionCAD
{
SeccionEN ReadOIDDefault (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                          );

void ModifyDefault (SeccionEN seccion);



MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum CrearSeccion (SeccionEN seccion);

void ModificarSeccion (SeccionEN seccion);


void BorrarSeccion (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                    );


SeccionEN ReadOID (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                   );


System.Collections.Generic.IList<SeccionEN> ReadAll (int first, int size);
}
}
