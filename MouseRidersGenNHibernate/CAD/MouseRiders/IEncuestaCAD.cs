
using System;
using MRModel.EN;

namespace MRModel.CAD
{
public partial interface IEncuestaCAD
{
EncuestaEN ReadOIDDefault (int id
                           );

void ModifyDefault (EncuestaEN encuesta);



int CrearEncuesta (EncuestaEN encuesta);

void ModificarEncuesta (EncuestaEN encuesta);


void BorrarEncuesta (int id
                     );




EncuestaEN ReadOID (int id
                    );


System.Collections.Generic.IList<EncuestaEN> ReadAll (int first, int size);


System.Collections.Generic.IList<MRModel.EN.EncuestaEN> ReadFilter (string p_titulo);
}
}
