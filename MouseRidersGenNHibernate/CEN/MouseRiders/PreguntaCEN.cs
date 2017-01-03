

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
 *      Definition of the class PreguntaCEN
 *
 */
public partial class PreguntaCEN
{
private IPreguntaCAD _IPreguntaCAD;

public PreguntaCEN()
{
        this._IPreguntaCAD = new PreguntaCAD ();
}

public PreguntaCEN(IPreguntaCAD _IPreguntaCAD)
{
        this._IPreguntaCAD = _IPreguntaCAD;
}

public IPreguntaCAD get_IPreguntaCAD ()
{
        return this._IPreguntaCAD;
}

public int CrearPregunta (string p_pregunta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum p_tipo, int p_pertenece)
{
        PreguntaEN preguntaEN = null;
        int oid;

        //Initialized PreguntaEN
        preguntaEN = new PreguntaEN ();
        preguntaEN.Pregunta = p_pregunta;

        preguntaEN.Tipo = p_tipo;


        if (p_pertenece != -1) {
                // El argumento p_pertenece -> Property pertenece es oid = false
                // Lista de oids id
                preguntaEN.Pertenece = new MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN ();
                preguntaEN.Pertenece.Id = p_pertenece;
        }

        //Call to PreguntaCAD

        oid = _IPreguntaCAD.CrearPregunta (preguntaEN);
        return oid;
}

public void ModificarPregunta (int p_Pregunta_OID, string p_pregunta, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_PreguntaEnum p_tipo)
{
        PreguntaEN preguntaEN = null;

        //Initialized PreguntaEN
        preguntaEN = new PreguntaEN ();
        preguntaEN.Id = p_Pregunta_OID;
        preguntaEN.Pregunta = p_pregunta;
        preguntaEN.Tipo = p_tipo;
        //Call to PreguntaCAD

        _IPreguntaCAD.ModificarPregunta (preguntaEN);
}

public void BorrarPregunta (int id
                            )
{
        _IPreguntaCAD.BorrarPregunta (id);
}
}
}
