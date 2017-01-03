
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
 * Clase Recompensa:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class RecompensaCAD : BasicCAD, IRecompensaCAD
{
public RecompensaCAD() : base ()
{
}

public RecompensaCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecompensaEN ReadOIDDefault (int id
                                    )
{
        RecompensaEN recompensaEN = null;

        try
        {
                SessionInitializeTransaction ();
                recompensaEN = (RecompensaEN)session.Get (typeof(RecompensaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recompensaEN;
}

public System.Collections.Generic.IList<RecompensaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RecompensaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RecompensaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RecompensaEN>();
                        else
                                result = session.CreateCriteria (typeof(RecompensaEN)).List<RecompensaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RecompensaEN recompensa)
{
        try
        {
                SessionInitializeTransaction ();
                RecompensaEN recompensaEN = (RecompensaEN)session.Load (typeof(RecompensaEN), recompensa.Id);

                recompensaEN.Nombre = recompensa.Nombre;


                recompensaEN.Descripcion = recompensa.Descripcion;



                recompensaEN.Puntuacion = recompensa.Puntuacion;

                session.Update (recompensaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearRecompensa (RecompensaEN recompensa)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (recompensa);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recompensa.Id;
}

public void ModificarRecompensa (RecompensaEN recompensa)
{
        try
        {
                SessionInitializeTransaction ();
                RecompensaEN recompensaEN = (RecompensaEN)session.Load (typeof(RecompensaEN), recompensa.Id);

                recompensaEN.Nombre = recompensa.Nombre;


                recompensaEN.Descripcion = recompensa.Descripcion;


                recompensaEN.Puntuacion = recompensa.Puntuacion;

                session.Update (recompensaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarRecompensa (int id
                              )
{
        try
        {
                SessionInitializeTransaction ();
                RecompensaEN recompensaEN = (RecompensaEN)session.Load (typeof(RecompensaEN), id);
                session.Delete (recompensaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RecompensaEN
public RecompensaEN ReadOID (int id
                             )
{
        RecompensaEN recompensaEN = null;

        try
        {
                SessionInitializeTransaction ();
                recompensaEN = (RecompensaEN)session.Get (typeof(RecompensaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recompensaEN;
}

public System.Collections.Generic.IList<RecompensaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecompensaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RecompensaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RecompensaEN>();
                else
                        result = session.CreateCriteria (typeof(RecompensaEN)).List<RecompensaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> ReadFilter (string p_nombre)
{
        System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RecompensaEN self where FROM RecompensaEN where :p_nombre like nombre or :p_nombre like descripcion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RecompensaENreadFilterHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RecompensaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
