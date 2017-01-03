
using System;
using System.Text;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.Exceptions;


/*
 * Clase Respuesta:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class RespuestaCAD : BasicCAD, IRespuestaCAD
{
public RespuestaCAD() : base ()
{
}

public RespuestaCAD(ISession sessionAux) : base (sessionAux)
{
}



public RespuestaEN ReadOIDDefault (int id
                                   )
{
        RespuestaEN respuestaEN = null;

        try
        {
                SessionInitializeTransaction ();
                respuestaEN = (RespuestaEN)session.Get (typeof(RespuestaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return respuestaEN;
}

public System.Collections.Generic.IList<RespuestaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RespuestaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RespuestaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RespuestaEN>();
                        else
                                result = session.CreateCriteria (typeof(RespuestaEN)).List<RespuestaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RespuestaEN respuesta)
{
        try
        {
                SessionInitializeTransaction ();
                RespuestaEN respuestaEN = (RespuestaEN)session.Load (typeof(RespuestaEN), respuesta.Id);

                respuestaEN.Respuesta = respuesta.Respuesta;


                respuestaEN.Tipo = respuesta.Tipo;



                respuestaEN.Contador = respuesta.Contador;


                respuestaEN.Frecuencia = respuesta.Frecuencia;

                session.Update (respuestaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearRespuesta (RespuestaEN respuesta)
{
        try
        {
                SessionInitializeTransaction ();
                if (respuesta.Pertenece != null) {
                        // Argumento OID y no colección.
                        respuesta.Pertenece = (MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.PreguntaEN), respuesta.Pertenece.Id);

                        respuesta.Pertenece.Tiene
                        .Add (respuesta);
                }

                session.Save (respuesta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return respuesta.Id;
}

public void ModificarRespuesta (RespuestaEN respuesta)
{
        try
        {
                SessionInitializeTransaction ();
                RespuestaEN respuestaEN = (RespuestaEN)session.Load (typeof(RespuestaEN), respuesta.Id);

                respuestaEN.Respuesta = respuesta.Respuesta;


                respuestaEN.Tipo = respuesta.Tipo;


                respuestaEN.Contador = respuesta.Contador;


                respuestaEN.Frecuencia = respuesta.Frecuencia;

                session.Update (respuestaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarRespuesta (int id
                             )
{
        try
        {
                SessionInitializeTransaction ();
                RespuestaEN respuestaEN = (RespuestaEN)session.Load (typeof(RespuestaEN), id);
                session.Delete (respuestaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
