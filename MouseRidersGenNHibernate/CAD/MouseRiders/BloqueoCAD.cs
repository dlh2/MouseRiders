
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
 * Clase Bloqueo:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class BloqueoCAD : BasicCAD, IBloqueoCAD
{
public BloqueoCAD() : base ()
{
}

public BloqueoCAD(ISession sessionAux) : base (sessionAux)
{
}



public BloqueoEN ReadOIDDefault (int id
                                 )
{
        BloqueoEN bloqueoEN = null;

        try
        {
                SessionInitializeTransaction ();
                bloqueoEN = (BloqueoEN)session.Get (typeof(BloqueoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bloqueoEN;
}

public System.Collections.Generic.IList<BloqueoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<BloqueoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(BloqueoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<BloqueoEN>();
                        else
                                result = session.CreateCriteria (typeof(BloqueoEN)).List<BloqueoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (BloqueoEN bloqueo)
{
        try
        {
                SessionInitializeTransaction ();
                BloqueoEN bloqueoEN = (BloqueoEN)session.Load (typeof(BloqueoEN), bloqueo.Id);



                bloqueoEN.FechaInicio = bloqueo.FechaInicio;


                bloqueoEN.FechaFin = bloqueo.FechaFin;

                session.Update (bloqueoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearBloqueo (BloqueoEN bloqueo)
{
        try
        {
                SessionInitializeTransaction ();
                if (bloqueo.Contiene != null) {
                        for (int i = 0; i < bloqueo.Contiene.Count; i++) {
                                bloqueo.Contiene [i] = (MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN), bloqueo.Contiene [i].Id);
                                bloqueo.Contiene [i].Pertenece = bloqueo;
                        }
                }
                if (bloqueo.Pertenece != null) {
                        // Argumento OID y no colección.
                        bloqueo.Pertenece = (MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN), bloqueo.Pertenece.Id);

                        bloqueo.Pertenece.Es_de
                                = bloqueo;
                }

                session.Save (bloqueo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bloqueo.Id;
}

public void ModificarBloqueo (BloqueoEN bloqueo)
{
        try
        {
                SessionInitializeTransaction ();
                BloqueoEN bloqueoEN = (BloqueoEN)session.Load (typeof(BloqueoEN), bloqueo.Id);

                bloqueoEN.FechaInicio = bloqueo.FechaInicio;


                bloqueoEN.FechaFin = bloqueo.FechaFin;

                session.Update (bloqueoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarBloqueo (int id
                           )
{
        try
        {
                SessionInitializeTransaction ();
                BloqueoEN bloqueoEN = (BloqueoEN)session.Load (typeof(BloqueoEN), id);
                session.Delete (bloqueoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: BloqueoEN
public BloqueoEN ReadOID (int id
                          )
{
        BloqueoEN bloqueoEN = null;

        try
        {
                SessionInitializeTransaction ();
                bloqueoEN = (BloqueoEN)session.Get (typeof(BloqueoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bloqueoEN;
}

public System.Collections.Generic.IList<BloqueoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<BloqueoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(BloqueoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<BloqueoEN>();
                else
                        result = session.CreateCriteria (typeof(BloqueoEN)).List<BloqueoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in BloqueoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
