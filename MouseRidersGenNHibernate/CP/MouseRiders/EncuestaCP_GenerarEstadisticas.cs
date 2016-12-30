
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MRModel.EN;
using MRModel.CAD;
using MRModel.CEN;



/*PROTECTED REGION ID(usingMRModel.CP_Encuesta_generarEstadisticas) ENABLED START*/
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MRModel.CP
{
public partial class EncuestaCP : BasicCP
{
public void GenerarEstadisticas ()
{
        /*PROTECTED REGION ID(MRModel.CP_Encuesta_generarEstadisticas) ENABLED START*/

        IEncuestaCAD _IEncuestaCAD = null;
        EncuestaCEN encuestaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                _IEncuestaCAD = new EncuestaCAD (session);
                encuestaCEN = new  EncuestaCEN (_IEncuestaCAD);



                IList<EncuestaEN> listaEncuestas = _IEncuestaCAD.ReadAll (0, 1000);
                for (int i = 0; i < listaEncuestas.Count; i++) {
                        for (int j = 0; j < listaEncuestas [i].Tiene.Count; j++) {
                                int porcentaje = 0;
                                for (int k = 0; k < listaEncuestas [i].Tiene [j].Tiene.Count; k++) {
                                        porcentaje += listaEncuestas [i].Tiene [j].Tiene [k].Contador;
                                }
                                for (int k = 0; k < listaEncuestas [i].Tiene [j].Tiene.Count; k++) {
                                        listaEncuestas [i].Tiene [j].Tiene [k].Frecuencia = (float)listaEncuestas [i].Tiene [j].Tiene [k].Contador / (float)porcentaje;
                                }
                        }
                        _IEncuestaCAD.ModificarEncuesta (listaEncuestas [i]);
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


        /*PROTECTED REGION END*/
}
}
}
