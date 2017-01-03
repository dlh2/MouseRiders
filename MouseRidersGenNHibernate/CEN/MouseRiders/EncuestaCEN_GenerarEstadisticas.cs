
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


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Encuesta_generarEstadisticas) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class EncuestaCEN
{
public void GenerarEstadisticas ()
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Encuesta_generarEstadisticas) ENABLED START*/

        IList<EncuestaEN> listaEncuestas = _IEncuestaCAD.ReadAll (0, 1000);
        for (int i = 0; i < listaEncuestas.Count; i++) {
                for (int j = 0; j < listaEncuestas [i].Tiene.Count; j++) {
                        int porcentaje = 0;
                        for (int k = 0; k < listaEncuestas [i].Tiene [j].Tiene.Count; k++) {
                                porcentaje += listaEncuestas [i].Tiene [j].Tiene [k].Contador;
                        }
                        for (int k = 0; k < listaEncuestas [i].Tiene [j].Tiene.Count; k++) {
                                listaEncuestas [i].Tiene [j].Tiene [k].Frecuencia = listaEncuestas [i].Tiene [j].Tiene [k].Contador / porcentaje;
                        }
                }
                _IEncuestaCAD.ModificarEncuesta (listaEncuestas [i]);
        }
        /*PROTECTED REGION END*/
}
}
}
