
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Usuario_recibirMensaje) ENABLED START*/
//  references to other libraries
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
public partial class UsuarioCP : BasicCP
{
public string RecibirMensaje (string p_oid, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum p_tipo)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Usuario_recibirMensaje) ENABLED START*/
        /*
         *  try
         *  {
         *          SessionInitializeTransaction ();
         *          //Prerequisitos basicos
         *          string email;
         *          string[] mensajes = new string [10];
         *          MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum tipo = p_tipo;
         *          //Inicializacion basico
         *          email = p_oid;
         *          /*
         *  MensajeCEN mes = new MensajeCEN(_IMensajeCAD);
         *  mes.ReadFilter_RecibirMensajes;
         * */
        /*       IQuery query = (IQuery)session.CreateQuery ("SELECT Mensaje FROM UsuarioEN as us where us.Mensaje.Tipo = " + tipo + " and us.email = " + email);
         *     IList<MensajeEN> men = query.List<MensajeEN>();
         *     SessionCommit ();
         *     //Contenido
         *     for (int i = 0; i < mensajes.Length; i++) {
         *             //usuarioEN.Recibe[i].Tipo ==tipo;
         *             //TODO: La segunda condicion no deberia hacer falta, pero esta por si acaso.
         *             MensajeEN mensajeEN = i < men.Count && men [i].Tipo.Equals (tipo)
         *                                   ? men [i] : null;
         *             mensajes [i] = mensajeEN != null ? mensajeEN.Texto : "";
         *     }
         *     //Finalizar
         *     for (int i = 0; i < mensajes.Length; i++) {
         *             System.Console.WriteLine ((i <= 10 ? "0" + i : "" + i) + ":" + mensajes [i]);
         *     }
         * }
         * catch (Exception ex)
         * {
         *     SessionRollBack ();
         *     throw ex;
         * }
         * finally
         * {
         *     SessionClose ();
         * }*/
        return null;




        /*PROTECTED REGION END*/
}
}
}
