
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IArticuloCAD
{
ArticuloEN ReadOIDDefault (int id
                           );

void ModifyDefault (ArticuloEN articulo);



int CrearArticulo (ArticuloEN articulo);

void ModificarArticulo (ArticuloEN articulo);


void BorrarArticulo (int id
                     );


ArticuloEN ReadOID (int id
                    );


System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size);
}
}
