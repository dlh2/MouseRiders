
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
 * Clase Pregunta:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class PreguntaCAD : BasicCAD, IPreguntaCAD
{
public PreguntaCAD() : base ()
{
}

public PreguntaCAD(ISession sessionAux) : base (sessionAux)
{
}



public PreguntaEN ReadOIDDefault (int id
                                  )
{
        PreguntaEN preguntaEN = null;

        try
        {
                SessionInitializeTransaction ();
                preguntaEN = (PreguntaEN)session.Get (typeof(PreguntaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PreguntaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return preguntaEN;
}

public System.Collections.Generic.IList<PreguntaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PreguntaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PreguntaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PreguntaEN>();
                        else
                                result = session.CreateCriteria (typeof(PreguntaEN)).List<PreguntaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PreguntaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PreguntaEN pregunta)
{
        try
        {
                SessionInitializeTransaction ();
                PreguntaEN preguntaEN = (PreguntaEN)session.Load (typeof(PreguntaEN), pregunta.Id);

                preguntaEN.Pregunta = pregunta.Pregunta;


                preguntaEN.Tipo = pregunta.Tipo;



                session.Update (preguntaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PreguntaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearPregunta (PreguntaEN pregunta)
{
        try
        {
                SessionInitializeTransaction ();
                if (pregunta.Pertenece != null) {
                        // Argumento OID y no colección.
                        pregunta.Pertenece = (MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.EncuestaEN), pregunta.Pertenece.Id);

                        pregunta.Pertenece.Tiene
                        .Add (pregunta);
                }

                session.Save (pregunta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PreguntaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pregunta.Id;
}

public void ModificarPregunta (PreguntaEN pregunta)
{
        try
        {
                SessionInitializeTransaction ();
                PreguntaEN preguntaEN = (PreguntaEN)session.Load (typeof(PreguntaEN), pregunta.Id);

                preguntaEN.Pregunta = pregunta.Pregunta;


                preguntaEN.Tipo = pregunta.Tipo;

                session.Update (preguntaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PreguntaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPregunta (int id
                            )
{
        try
        {
                SessionInitializeTransaction ();
                PreguntaEN preguntaEN = (PreguntaEN)session.Load (typeof(PreguntaEN), id);
                session.Delete (preguntaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PreguntaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
