
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IControladorEncuestaCAD
{
ControladorEncuestaEN ReadOIDDefault (int id
                                      );

void ModifyDefault (ControladorEncuestaEN controladorEncuesta);



int CrearCEncuesta (ControladorEncuestaEN controladorEncuesta);

void ModificarCEncuesta (ControladorEncuestaEN controladorEncuesta);


void BorrarCEncuesta (int id
                      );
}
}
