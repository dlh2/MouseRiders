
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IBloqueoCAD
{
BloqueoEN ReadOIDDefault (int id
                          );

void ModifyDefault (BloqueoEN bloqueo);



int CrearBloqueo (BloqueoEN bloqueo);

void ModificarBloqueo (BloqueoEN bloqueo);


void BorrarBloqueo (int id
                    );


BloqueoEN ReadOID (int id
                   );


System.Collections.Generic.IList<BloqueoEN> ReadAll (int first, int size);
}
}
