
using System;
using MRModel.EN;

namespace MRModel.CAD
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
