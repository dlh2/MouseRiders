
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Administrador_bloquearUsuario) ENABLED START*/
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
public partial class AdministradorCP : BasicCP
{
public bool BloquearUsuario (int p_oid, int p_dias)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Administrador_bloquearUsuario) ENABLED START*/


        /*
         *
         * busca y lee las denuncias de un usuario y crea un bloqueo a ese usuario si tiene mas de tres denuncias
         *
         *
         *
         */
        bool bloqueado = false;

        try
        {
                SessionInitializeTransaction ();
                IUsuarioCAD _IUsuarioCAD = new UsuarioCAD (session);
                int Ndenuncias = 0;

                UsuarioEN _usuarioEN = _IUsuarioCAD.ReadOIDDefault (p_oid);

                if (_usuarioEN != null)
                        Ndenuncias = _usuarioEN.RecibeD.Count;

                if (Ndenuncias >= 3 && p_dias > 0) {
                        IBloqueoCAD _IBloqueoCAD = new BloqueoCAD ();
                        BloqueoCEN bloqueoCEN = new BloqueoCEN (_IBloqueoCAD);
                        UsuarioCEN usuarioCEN = new UsuarioCEN (_IUsuarioCAD);


                        BloqueoEN bloqueoEN = new BloqueoEN ();
                        bloqueoEN.FechaInicio = DateTime.Now;
                        bloqueoEN.FechaFin = DateTime.Now.AddDays (p_dias);

                        IList<int> list = new List<int>();
                        IList<DenunciaEN> list1 = _usuarioEN.RecibeD;
                        for (int i = 0; i < _usuarioEN.RecibeD.Count; i++) {
                                list.Add (list1 [i].Id);
                        }

                        int aux = bloqueoCEN.CrearBloqueo (list, p_oid, bloqueoEN.FechaInicio, bloqueoEN.FechaFin);

                        usuarioCEN.RelacionaBloqueo (p_oid, aux);

                        bloqueado = true;
                }
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
        return(bloqueado);
        /*PROTECTED REGION END*/
}
}
}
