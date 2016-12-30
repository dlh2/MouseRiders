
using System;
using MRModel.EN;

namespace MRModel.CAD
{
public partial interface IDenunciaCAD
{
DenunciaEN ReadOIDDefault (int id
                           );

void ModifyDefault (DenunciaEN denuncia);



int CrearDenuncia (DenunciaEN denuncia);

void ModificarDenuncia (DenunciaEN denuncia);


void BorrarDenuncia (int id
                     );


DenunciaEN ReadOID (int id
                    );


System.Collections.Generic.IList<DenunciaEN> ReadAll (int first, int size);
}
}
