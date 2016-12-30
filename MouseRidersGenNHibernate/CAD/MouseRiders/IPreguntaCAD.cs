
using System;
using MRModel.EN;

namespace MRModel.CAD
{
public partial interface IPreguntaCAD
{
PreguntaEN ReadOIDDefault (int id
                           );

void ModifyDefault (PreguntaEN pregunta);



int CrearPregunta (PreguntaEN pregunta);

void ModificarPregunta (PreguntaEN pregunta);


void BorrarPregunta (int id
                     );
}
}
