
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IControladorNotificacionesCAD
{
ControladorNotificacionesEN ReadOIDDefault (int id
                                            );

void ModifyDefault (ControladorNotificacionesEN controladorNotificaciones);



int CrearCNotificaciones (ControladorNotificacionesEN controladorNotificaciones);

void ModificarCNotificaciones (ControladorNotificacionesEN controladorNotificaciones);


void BorrarCNotificaciones (int id
                            );



ControladorNotificacionesEN ReadOID (int id
                                     );


System.Collections.Generic.IList<ControladorNotificacionesEN> ReadAll (int first, int size);
}
}
