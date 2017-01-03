

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.Exceptions;

using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;


namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
/*
 *      Definition of the class RespuestaCEN
 *
 */
public partial class RespuestaCEN
{
private IRespuestaCAD _IRespuestaCAD;

public RespuestaCEN()
{
        this._IRespuestaCAD = new RespuestaCAD ();
}

public RespuestaCEN(IRespuestaCAD _IRespuestaCAD)
{
        this._IRespuestaCAD = _IRespuestaCAD;
}

public IRespuestaCAD get_IRespuestaCAD ()
{
        return this._IRespuestaCAD;
}

public int CrearRespuesta (string p_respuesta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum p_tipo, int p_pertenece, int p_contador, float p_frecuencia)
{
        RespuestaEN respuestaEN = null;
        int oid;

        //Initialized RespuestaEN
        respuestaEN = new RespuestaEN ();
        respuestaEN.Respuesta = p_respuesta;

        respuestaEN.Tipo = p_tipo;


        if (p_pertenece != -1) {
                // El argumento p_pertenece -> Property pertenece es oid = false
                // Lista de oids id
                respuestaEN.Pertenece = new MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN ();
                respuestaEN.Pertenece.Id = p_pertenece;
        }

        respuestaEN.Contador = p_contador;

        respuestaEN.Frecuencia = p_frecuencia;

        //Call to RespuestaCAD

        oid = _IRespuestaCAD.CrearRespuesta (respuestaEN);
        return oid;
}

public void ModificarRespuesta (int p_Respuesta_OID, string p_respuesta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum p_tipo, int p_contador, float p_frecuencia)
{
        RespuestaEN respuestaEN = null;

        //Initialized RespuestaEN
        respuestaEN = new RespuestaEN ();
        respuestaEN.Id = p_Respuesta_OID;
        respuestaEN.Respuesta = p_respuesta;
        respuestaEN.Tipo = p_tipo;
        respuestaEN.Contador = p_contador;
        respuestaEN.Frecuencia = p_frecuencia;
        //Call to RespuestaCAD

        _IRespuestaCAD.ModificarRespuesta (respuestaEN);
}

public void BorrarRespuesta (int id
                             )
{
        _IRespuestaCAD.BorrarRespuesta (id);
}
}
}
