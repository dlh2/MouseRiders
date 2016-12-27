
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IRedactorCAD
{
RedactorEN ReadOIDDefault (int id
                           );

void ModifyDefault (RedactorEN redactor);



int CrearRedactor (RedactorEN redactor);

void ModificarRedactor (RedactorEN redactor);


void BorrarRedactor (int id
                     );


RedactorEN ReadOID (int id
                    );


System.Collections.Generic.IList<RedactorEN> ReadAll (int first, int size);
}
}
