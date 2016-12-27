
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IForoCAD
{
ForoEN ReadOIDDefault (int id
                       );

void ModifyDefault (ForoEN foro);



int CrearForo (ForoEN foro);

void ModificarForo (ForoEN foro);


void BorrarForo (int id
                 );
}
}
