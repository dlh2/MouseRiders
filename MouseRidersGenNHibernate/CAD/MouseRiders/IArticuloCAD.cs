
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



System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> ReadFilter (string p_nombre, Nullable<DateTime> p_fecha, bool? p_mayor, float? p_puntuacion, bool ? p_mayor1);
}
}
