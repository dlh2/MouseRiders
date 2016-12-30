
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MRModel.EN;
using MRModel.CAD;
using MRModel.CEN;



/*PROTECTED REGION ID(usingMRModel.CP_ControladorNotificaciones_enviarNotificaciones) ENABLED START*/
using System.Collections.Generic;
using MRModel.Enumerated;
/*PROTECTED REGION END*/

namespace MRModel.CP
{
public partial class ControladorNotificacionesCP : BasicCP
{
public bool EnviarNotificaciones (MRModel.EN.PermisoEN permiso, MRModel.EN.RecompensaEN oidRecompensa, string asunto, string texto, string adjunto)
{
        /*PROTECTED REGION ID(MRModel.CP_ControladorNotificaciones_enviarNotificaciones) ENABLED START*/

        IControladorNotificacionesCAD controladorNotificacionesCAD = null;
        ControladorNotificacionesCEN controladorNotificacionesCEN = null;
        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                controladorNotificacionesCAD = new ControladorNotificacionesCAD (session);
                controladorNotificacionesCEN = new  ControladorNotificacionesCEN (controladorNotificacionesCAD);
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);
                IList<UsuarioEN> list = null;
                list = usuarioCEN.ReadAll (0, 100);
                IList<UsuarioEN> listAux = new List<UsuarioEN>();


                if (asunto == null || texto == null)
                        return false;

                if (list == null)
                        return false;

                if (permiso == null && oidRecompensa == null) {
                        listAux = list;
                }

                if (permiso != null && oidRecompensa == null) {
                        for (int i = 0; i < list.Count; i++) {
                                for (int j = 0; j < list [i].Tiene.Count; j++) {
                                        if (list [i].Tiene [j].PermisoOID == permiso.PermisoOID)
                                                listAux.Add (list [i]);
                                }
                        }
                }

                if (permiso == null && oidRecompensa != null) {
                        for (int i = 0; i < list.Count; i++) {
                                for (int j = 0; j < list [i].Obtiene.Count; j++) {
                                        if (list [i].Obtiene [j].Id == oidRecompensa.Id)
                                                listAux.Add (list [i]);
                                }
                        }
                }

                if (permiso != null && oidRecompensa != null) {
                        for (int i = 0; i < list.Count; i++) {
                                int x = 0;
                                for (int j = 0; j < list [i].Obtiene.Count; j++) {
                                        if (list [i].Obtiene [j].Id == oidRecompensa.Id)
                                                x++;
                                }
                                for (int k = 0; k < list [i].Tiene.Count; k++) {
                                        if (list [i].Tiene [k].PermisoOID == permiso.PermisoOID)
                                                x++;
                                }
                                if (x == 2)
                                        listAux.Add (list [i]);
                        }
                }

                if (listAux == null)
                        return false;

                IList<int> listAux1 = new List<int>();
                for (int i = 0; i < listAux.Count; i++) {
                        listAux1.Add (listAux [i].Id);
                }

                IMensajeCAD mensajeCAD = new MensajeCAD ();
                MensajeCEN mensajeCEN = new MensajeCEN (mensajeCAD);
                int oid = mensajeCEN.CrearMensaje (asunto, texto, adjunto, T_MensajeEnum.notificacion, -1, listAux1);

                if (oid < 0)
                        return false;


                mensajeCEN.RelacionaMensaje (oid, controladorNotificacionesCEN.ReadAll (0, 1) [0].Id);

                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return true;

        /*PROTECTED REGION END*/
}
}
}
