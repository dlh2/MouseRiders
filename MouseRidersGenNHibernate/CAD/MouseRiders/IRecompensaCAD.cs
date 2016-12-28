
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IRecompensaCAD
{
RecompensaEN ReadOIDDefault (int id
                             );

void ModifyDefault (RecompensaEN recompensa);



int CrearRecompensa (RecompensaEN recompensa);

void ModificarRecompensa (RecompensaEN recompensa);


void BorrarRecompensa (int id
                       );


RecompensaEN ReadOID (int id
                      );


System.Collections.Generic.IList<RecompensaEN> ReadAll (int first, int size);


System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> ReadFilter (string p_nombre);
}
}
