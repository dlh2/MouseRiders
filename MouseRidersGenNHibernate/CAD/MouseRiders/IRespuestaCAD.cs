
using System;
using MRModel.EN;

namespace MRModel.CAD
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
