
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
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
