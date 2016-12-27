
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
 * Clase Foro:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class ForoCAD : BasicCAD, IForoCAD
{
public ForoCAD() : base ()
{
}

public ForoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ForoEN ReadOIDDefault (int id
                              )
{
        ForoEN foroEN = null;

        try
        {
                SessionInitializeTransaction ();
                foroEN = (ForoEN)session.Get (typeof(ForoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ForoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return foroEN;
}

public System.Collections.Generic.IList<ForoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ForoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ForoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ForoEN>();
                        else
                                result = session.CreateCriteria (typeof(ForoEN)).List<ForoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ForoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ForoEN foro)
{
        try
        {
                SessionInitializeTransaction ();
                ForoEN foroEN = (ForoEN)session.Load (typeof(ForoEN), foro.Id);

                session.Update (foroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ForoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearForo (ForoEN foro)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (foro);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ForoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return foro.Id;
}

public void ModificarForo (ForoEN foro)
{
        try
        {
                SessionInitializeTransaction ();
                ForoEN foroEN = (ForoEN)session.Load (typeof(ForoEN), foro.Id);
                session.Update (foroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ForoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarForo (int id
                        )
{
        try
        {
                SessionInitializeTransaction ();
                ForoEN foroEN = (ForoEN)session.Load (typeof(ForoEN), id);
                session.Delete (foroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ForoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
