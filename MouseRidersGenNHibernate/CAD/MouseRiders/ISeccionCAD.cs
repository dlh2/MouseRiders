
using System;
using MRModel.EN;

namespace MRModel.CAD
{
public partial interface ISeccionCAD
{
SeccionEN ReadOIDDefault (int seccion
                          );

void ModifyDefault (SeccionEN seccion);



int CrearSeccion (SeccionEN seccion);

void ModificarSeccion (SeccionEN seccion);


void BorrarSeccion (int seccion
                    );


SeccionEN ReadOID (int seccion
                   );


System.Collections.Generic.IList<SeccionEN> ReadAll (int first, int size);


MRModel.EN.SeccionEN ReadFilter (string p_nombre);
}
}
