
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Usuario_enviarMensaje) ENABLED START*/
//  references to other libraries
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
    public partial class UsuarioCP : BasicCP
    {
        public int EnviarMensaje(MouseRidersGenNHibernate.EN.MouseRiders.MensajeEN mensaje)
        {
            /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Usuario_enviarMensaje) ENABLED START*/
            int count = 0;
            try
            {
                // Write here your custom code...
                IMensajeCAD _IMensajeCAD = null;
                IList<UsuarioEN> destinos = new List<UsuarioEN>();
                destinos = mensaje.Es_recibido;
                _IMensajeCAD.CrearMensaje(mensaje);
                IUsuarioCAD _IUsuarioCAD = null;
                _IUsuarioCAD = new UsuarioCAD(session); //iniciar cad de usuario para acceder a los mails
                for (int i = 0; i < destinos.Count; i++)
                { //recorrer la lista de destinatarios comparando con los mails
                    UsuarioEN _usuarioEN = null;
                    _usuarioEN = _IUsuarioCAD.ReadOID(destinos[i].Email);
                    if (_usuarioEN != null)
                    {
                        _usuarioEN.Recibe.Add(mensaje); //anyadir mensaje a la lista de mensajes en la relacion
                        _IUsuarioCAD.ModificarUsuario(_usuarioEN); //actualizar la base de datos mandando el usuarioEN al cad
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                SessionRollBack();
                throw ex;
            }
            finally
            {
                SessionClose();
            }
            return (count);
            /*PROTECTED REGION END*/
        }
    }
}
