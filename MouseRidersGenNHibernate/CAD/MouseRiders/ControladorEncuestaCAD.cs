
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
 * Clase ControladorEncuesta:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class ControladorEncuestaCAD : BasicCAD, IControladorEncuestaCAD
{
public ControladorEncuestaCAD() : base ()
{
}

public ControladorEncuestaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ControladorEncuestaEN ReadOIDDefault (int id
                                             )
{
        ControladorEncuestaEN controladorEncuestaEN = null;

        try
        {
                SessionInitializeTransaction ();
                controladorEncuestaEN = (ControladorEncuestaEN)session.Get (typeof(ControladorEncuestaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ControladorEncuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return controladorEncuestaEN;
}

public System.Collections.Generic.IList<ControladorEncuestaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ControladorEncuestaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ControladorEncuestaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ControladorEncuestaEN>();
                        else
                                result = session.CreateCriteria (typeof(ControladorEncuestaEN)).List<ControladorEncuestaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ControladorEncuestaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ControladorEncuestaEN controladorEncuesta)
{
        try
        {
                SessionInitializeTransaction ();
                ControladorEncuestaEN controladorEncuestaEN = (ControladorEncuestaEN)session.Load (typeof(ControladorEncuestaEN), controladorEncuesta.Id);

                session.Update (controladorEncuestaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ControladorEncuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearCEncuesta (ControladorEncuestaEN controladorEncuesta)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (controladorEncuesta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ControladorEncuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return controladorEncuesta.Id;
}

public void ModificarCEncuesta (ControladorEncuestaEN controladorEncuesta)
{
        try
        {
                SessionInitializeTransaction ();
                ControladorEncuestaEN controladorEncuestaEN = (ControladorEncuestaEN)session.Load (typeof(ControladorEncuestaEN), controladorEncuesta.Id);
                session.Update (controladorEncuestaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ControladorEncuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarCEncuesta (int id
                             )
{
        try
        {
                SessionInitializeTransaction ();
                ControladorEncuestaEN controladorEncuestaEN = (ControladorEncuestaEN)session.Load (typeof(ControladorEncuestaEN), id);
                session.Delete (controladorEncuestaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ControladorEncuestaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
