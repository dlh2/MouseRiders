
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (ComentarioEN comentario);



int CrearComentario (ComentarioEN comentario);

void ModificarComentario (ComentarioEN comentario);


void BorrarComentario (int id
                       );



void RelacionaArticulo (int p_Comentario_OID, int p_pertenece_OID);

void RelacionaHilo (int p_Comentario_OID, int p_pertenece_a_OID);

int NumComentsArticulo (int ? p_id);


int NumComentsHilo (int ? p_id);


ComentarioEN ReadOID (int id
                      );


System.Collections.Generic.IList<ComentarioEN> ReadAll (int first, int size);
}
}
