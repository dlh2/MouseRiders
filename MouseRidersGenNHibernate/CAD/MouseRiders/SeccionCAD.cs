
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
 * Clase Seccion:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class SeccionCAD : BasicCAD, ISeccionCAD
{
public SeccionCAD() : base ()
{
}

public SeccionCAD(ISession sessionAux) : base (sessionAux)
{
}



public SeccionEN ReadOIDDefault (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                                 )
{
        SeccionEN seccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                seccionEN = (SeccionEN)session.Get (typeof(SeccionEN), seccion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seccionEN;
}

public System.Collections.Generic.IList<SeccionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SeccionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SeccionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SeccionEN>();
                        else
                                result = session.CreateCriteria (typeof(SeccionEN)).List<SeccionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SeccionEN seccion)
{
        try
        {
                SessionInitializeTransaction ();
                SeccionEN seccionEN = (SeccionEN)session.Load (typeof(SeccionEN), seccion.Seccion);

                session.Update (seccionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum CrearSeccion (SeccionEN seccion)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (seccion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seccion.Seccion;
}

public void ModificarSeccion (SeccionEN seccion)
{
        try
        {
                SessionInitializeTransaction ();
                SeccionEN seccionEN = (SeccionEN)session.Load (typeof(SeccionEN), seccion.Seccion);
                session.Update (seccionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarSeccion (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                           )
{
        try
        {
                SessionInitializeTransaction ();
                SeccionEN seccionEN = (SeccionEN)session.Load (typeof(SeccionEN), seccion);
                session.Delete (seccionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SeccionEN
public SeccionEN ReadOID (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_SeccionEnum seccion
                          )
{
        SeccionEN seccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                seccionEN = (SeccionEN)session.Get (typeof(SeccionEN), seccion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seccionEN;
}

public System.Collections.Generic.IList<SeccionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SeccionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SeccionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SeccionEN>();
                else
                        result = session.CreateCriteria (typeof(SeccionEN)).List<SeccionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
