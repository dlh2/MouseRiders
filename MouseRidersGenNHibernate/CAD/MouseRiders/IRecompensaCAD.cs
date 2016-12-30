
using System;
using MRModel.EN;

namespace MRModel.CAD
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


System.Collections.Generic.IList<MRModel.EN.RecompensaEN> ReadFilter (string p_nombre);
}
}
