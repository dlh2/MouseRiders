
using System;
using MRModel.EN;

namespace MRModel.CAD
{
public partial interface IAdmin_foroCAD
{
Admin_foroEN ReadOIDDefault (int id
                             );

void ModifyDefault (Admin_foroEN admin_foro);



int CrearAdmin_foro (Admin_foroEN admin_foro);

void ModificarAdmin_foro (Admin_foroEN admin_foro);


void BorrarAdmin_foro (int id
                       );


Admin_foroEN ReadOID (int id
                      );


System.Collections.Generic.IList<Admin_foroEN> ReadAll (int first, int size);
}
}
