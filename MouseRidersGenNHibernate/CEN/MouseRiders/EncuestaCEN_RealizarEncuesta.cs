
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


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Encuesta_realizarEncuesta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class EncuestaCEN
{
    public void RealizarEncuesta(int p_oid, IList<String> p_respuestas)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Encuesta_realizarEncuesta) ENABLED START*/
        //      public void RealizarEncuesta(int p_oid, IList<String> p_respuestas)
        EncuestaEN _encuesta;
        IEncuestaCAD _IEncuestaCAD = new EncuestaCAD();
        //EncuestaCEN encuestaCEN = new EncuestaCEN(_IEncuestaCAD);

        _encuesta = _IEncuestaCAD.ReadOIDDefault (p_oid);    //cargar encuesta
        for (int i = 0; i < _encuesta.Tiene.Count; i++) {   //recorrido de preguntas
                for (int j = 0; j < _encuesta.Tiene [i].Tiene.Count; j++) { // recorrido de respuestas
                        if (_encuesta.Tiene [i].Tiene [j].Respuesta.Equals (p_respuestas [i])) { //encontrar la respuesta seleccionada
                                _encuesta.Tiene [i].Tiene [j].Contador++; //cuando se encuentra se aumenta su contador
                        }
                }
        }
        _IEncuestaCAD.ModificarEncuesta (_encuesta);    //guardar cambios en el CAD

        /*PROTECTED REGION END*/
}
}
}
