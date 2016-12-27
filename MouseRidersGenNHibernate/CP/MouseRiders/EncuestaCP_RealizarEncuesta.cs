
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Encuesta_realizarEncuesta) ENABLED START*/
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
public partial class EncuestaCP : BasicCP
{
public void RealizarEncuesta (int p_oid, System.Collections.Generic.IList<string> p_respuestas)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Encuesta_realizarEncuesta) ENABLED START*/

        try
        {
                SessionInitializeTransaction ();
                /*  encuestaCAD = new EncuestaCAD (session);
                 * encuestaCEN = new  EncuestaCEN (encuestaCAD); */



                //      public void RealizarEncuesta(int p_oid, IList<String> p_respuestas)
                EncuestaEN _encuesta;
                IEncuestaCAD _IEncuestaCAD = new EncuestaCAD (session);
                //EncuestaCEN encuestaCEN = new EncuestaCEN(_IEncuestaCAD);

                _encuesta = _IEncuestaCAD.ReadOIDDefault (p_oid);    //cargar encuesta
                for (int i = 0; i < _encuesta.Tiene.Count; i++) { //recorrido de preguntas
                        for (int j = 0; j < _encuesta.Tiene [i].Tiene.Count; j++) { // recorrido de respuestas
                                if (_encuesta.Tiene [i].Tiene [j].Respuesta.Equals (p_respuestas [i])) { //encontrar la respuesta seleccionada
                                        _encuesta.Tiene [i].Tiene [j].Contador++; //cuando se encuentra se aumenta su contador
                                }
                        }
                }
                _IEncuestaCAD.ModificarEncuesta (_encuesta);    //guardar cambios en el CAD



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
