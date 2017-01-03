
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IRespuestaCAD
{
RespuestaEN ReadOIDDefault (int id
                            );

void ModifyDefault (RespuestaEN respuesta);



int CrearRespuesta (RespuestaEN respuesta);

void ModificarRespuesta (RespuestaEN respuesta);


void BorrarRespuesta (int id
                      );
}
}
