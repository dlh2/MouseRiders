
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
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


System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN> ReadFilter (string p_titulo);
}
}
