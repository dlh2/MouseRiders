
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IICAD
{
IEN ReadOIDDefault (int id
                    );

void ModifyDefault (IEN i);



int CrearBloqueo (IEN i);

void ModificarBloqueo (IEN i);


void BorrarBloqueo (int id
                    );


IEN ReadOID (int id
             );


System.Collections.Generic.IList<IEN> ReadAll (int first, int size);
}
}
