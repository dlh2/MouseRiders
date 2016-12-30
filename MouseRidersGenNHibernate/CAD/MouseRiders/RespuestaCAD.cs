
using System;
using System.Text;
using MRModel.CEN;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MRModel.EN;
using MRModel.Exceptions;


/*
 * Clase Respuesta:
 *
 */

namespace MRModel.CAD
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
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
                        respuesta.Pertenece = (MRModel.EN.PreguntaEN)session.Load (typeof(MRModel.EN.PreguntaEN), respuesta.Pertenece.Id);

                        respuesta.Pertenece.Tiene
                        .Add (respuesta);
                }

                session.Save (respuesta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in RespuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
