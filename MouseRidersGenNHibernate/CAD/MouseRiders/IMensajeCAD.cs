
using System;
using MouseRidersGenNHibernate.EN.MouseRiders;

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial interface IMensajeCAD
{
MensajeEN ReadOIDDefault (int id
                          );

void ModifyDefault (MensajeEN mensaje);



int CrearMensaje (MensajeEN mensaje);

void ModificarMensaje (MensajeEN mensaje);


void BorrarMensaje (int id
                    );


MensajeEN ReadOID (int id
                   );


System.Collections.Generic.IList<MensajeEN> ReadAll (int first, int size);


void RelacionaMensaje (int p_Mensaje_OID, int p_es_enviadoN_OID);
}
}
