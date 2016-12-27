
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Usuario_recibirMensaje) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class UsuarioCEN
{
public MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN RecibirMensaje (string p_oid)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Usuario_recibirMensaje) ENABLED START*/

        // Write here your custom code...

        /**
         * David
         *  recibirMensaje: comprueba si hay algun mensaje en la base de datos a nombre (email) del
         *  usuario, devuelve un array con los diez primeros mensajes a nombre del usuario, se le pasa
         *  email del usuario y tipo de mensaje, si el tipo de mensaje es distinto de null, se le pasa
         *  solo los diez primeros mensajes de ese tipo, si tipo es null, se le pasan los diez primeros
         *  mensajes de cualquier tipo.
         * */

        //Prerequisitos basicos
        UsuarioEN usuarioEN = null;
        string email;

        string[] mensajes = new string [10];
        //Inicializacion basico
        email = p_oid;
        usuarioEN = _IUsuarioCAD.ReadOID (email);

        //Contenido
        //TODO: Me falta el parametro del tipo
        for (int i = 0; i < mensajes.Length; i++) {
                MensajeEN mensajeEN = i < usuarioEN.Recibe.Count ? usuarioEN.Recibe [i] : null;
                mensajes [i] = mensajeEN != null ? mensajeEN.Texto : "";
        }
        //Finalizar
        for (int i = 0; i < mensajes.Length; i++) {
                System.Console.WriteLine ((i <= 10 ? "0" + i : "" + i) + ":" + mensajes [i]);
        }
        return null;
        /*PROTECTED REGION END*/
}
}
}
