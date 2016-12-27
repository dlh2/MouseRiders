
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IHiloCAD
{
HiloEN ReadOIDDefault (int id
                       );

void ModifyDefault (HiloEN hilo);



int CrearHilo (HiloEN hilo);

void ModificarHilo (HiloEN hilo);


void BorrarHilo (int id
                 );


HiloEN ReadOID (int id
                );


System.Collections.Generic.IList<HiloEN> ReadAll (int first, int size);
}
}
