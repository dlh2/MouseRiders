
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Encuesta_generarEstadisticas) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
public partial class EncuestaCP : BasicCP
{
public void GenerarEstadisticas ()
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Encuesta_generarEstadisticas) ENABLED START*/

        IEncuestaCAD encuestaCAD = null;
        EncuestaCEN encuestaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                encuestaCAD = new EncuestaCAD (session);
                encuestaCEN = new  EncuestaCEN (encuestaCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method GenerarEstadisticas() not yet implemented.");



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


        /*PROTECTED REGION END*/
}
}
}
