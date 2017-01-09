
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_ControladorNotificaciones_enviarNitificaciones) ENABLED START*/
//  references to other libraries
using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
    public partial class ControladorNotificacionesCP : BasicCP
    {
        public void EnviarNitificaciones(MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN permiso, MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN oidRecompensa, string asunto, string texto, string adjunto)
        {
            /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_ControladorNotificaciones_enviarNitificaciones) ENABLED START*/
            try
            {
                /*
                 * envia un mensaje a varios o todos los usuarios de la web, dependiendo de sus
                 * recompensas o privilegios,
                 * es decir, se le pasan por parametro recompensas y privilegios, si estan a null
                 * se envia el mensaje a todos los usuarios,
                 * si no, se hace un filtrado por usuarios que tiene cierta puntuacion o permiso y
                 * se envia a los que entren
                 *
                 */
                IUsuarioCAD _IusuarioCAD = new UsuarioCAD(session);
                IList<UsuarioEN> users;
                IList<String> acotao = null;
                users = _IusuarioCAD.ReadAll(0, 999999);
                UsuarioEN _usuario1 = new UsuarioEN();
                for (int i = 0; i < users.Count; i++)
                {
                    if (permiso == null && oidRecompensa == null)
                    { //la lista acotada contiene todos los usuarios
                        acotao.Add(users[i].Email);
                    }
                    else if (permiso == null && oidRecompensa != null)
                    { //la lista acotada contiene los usuarios con la recompensa pasado por parametro
                        if (users[i].Obtiene.Contains(oidRecompensa))
                        {
                            acotao.Add(users[i].Email);
                        }
                    }
                    else if (permiso != null && oidRecompensa == null)
                    { //la lista acotada contiene los usuarios con el permiso pasado por parametro
                        if (users[i].Tiene.Contains(permiso))
                        {
                            acotao.Add(users[i].Email);
                        }
                    }
                    else
                    { // la lista acotada tiene en cuenta tanto el permiso como la recompensa
                        if (users[i].Obtiene.Contains(oidRecompensa))
                        {
                            if (users[i].Tiene.Contains(permiso))
                            {
                                acotao.Add(users[i].Email);
                            }
                        }
                    }
                }

                MensajeEN _mensaje = new MensajeEN();
                IMensajeCAD _IMensajeCAD = new MensajeCAD();
                MensajeCEN mensajeCEN = new MensajeCEN(_IMensajeCAD);
                mensajeCEN.CrearMensaje(asunto, texto, adjunto, T_MensajeEnum.notificacion, _usuario1.Email, acotao);
                UsuarioEN aux;
                IUsuarioCAD _IUsuarioCAD = new UsuarioCAD();
                UsuarioCEN usuarioCEN = new UsuarioCEN(_IusuarioCAD);
                for (int j = 0; j < acotao.Count; j++)
                {
                    aux = usuarioCEN.ReadOID(acotao[j]);
                    aux.Recibe.Add(_mensaje);
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
            /*PROTECTED REGION END*/
        }
    }
}
