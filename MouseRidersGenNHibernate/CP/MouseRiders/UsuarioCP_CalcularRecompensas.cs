
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Usuario_calcularRecompensas) ENABLED START*/
//  references to other libraries
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
public partial class UsuarioCP : BasicCP
{
public bool CalcularRecompensas (int p_oid)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Usuario_calcularRecompensas) ENABLED START*/

        try
        {
                SessionInitializeTransaction ();


                UsuarioCEN usuarioCEN = null;
                UsuarioCAD usuarioCAD = null;
                RecompensaCEN recompensaCEN = null;
                RecompensaCAD recompensaCAD = null;

                UsuarioEN usuarioEN = null;

                recompensaCAD = new RecompensaCAD ();
                usuarioCAD = new UsuarioCAD ();
                recompensaCEN = new RecompensaCEN (recompensaCAD);
                usuarioCEN = new UsuarioCEN (usuarioCAD);

                usuarioEN = usuarioCEN.ReadOID (p_oid);

                if (usuarioEN == null)
                        return false;

                int aux1 = usuarioEN.Puntuacion;
                IQuery query = session.CreateQuery ("from RecompensaEN where puntuacion <= :puntos");
                query.SetParameter ("puntos", aux1);
                IList<RecompensaEN> recompensas = query.List<RecompensaEN>();

                if (recompensas == null || recompensas.Count <= 0)
                        return false;

                IList<int> aux = new List<int>();

                for (int i = 0; i < recompensas.Count; i++) {
                        aux.Add (recompensas [i].Id);
                }

                usuarioCEN.RelacionaRecompensa (p_oid, aux);

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
