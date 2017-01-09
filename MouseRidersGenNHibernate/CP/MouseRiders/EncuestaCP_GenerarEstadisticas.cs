
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
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
    public partial class EncuestaCP : BasicCP
    {
        public void GenerarEstadisticas()
        {
            /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Encuesta_generarEstadisticas) ENABLED START*/
            EncuestaCEN encuestaCEN = null;
            try
            {
                encuestaCEN = new EncuestaCEN(new EncuestaCAD(session));
                IList<EncuestaEN> listaEncuestas = encuestaCEN.ReadAll(0, 1000);
                for (int i = 0; i < listaEncuestas.Count; i++)
                {
                    for (int j = 0; j < listaEncuestas[i].Tiene.Count; j++)
                    {
                        int porcentaje = 0;
                        for (int k = 0; k < listaEncuestas[i].Tiene[j].Tiene.Count; k++)
                        {
                            porcentaje += listaEncuestas[i].Tiene[j].Tiene[k].Contador;
                        }
                        for (int k = 0; k < listaEncuestas[i].Tiene[j].Tiene.Count; k++)
                        {
                            RespuestaEN resp = listaEncuestas[i].Tiene[j].Tiene[k];
                            resp.Frecuencia = (float)listaEncuestas[i].Tiene[j].Tiene[k].Contador / (float)porcentaje;
                            new RespuestaCEN().ModificarRespuesta(resp.Id,
                                resp.Respuesta, resp.Tipo, resp.Contador, resp.Frecuencia);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Le falta la variable session al CP de GenerarEstadisticas");
                throw ex;
            }


            /*PROTECTED REGION END*/
        }
    }
}
