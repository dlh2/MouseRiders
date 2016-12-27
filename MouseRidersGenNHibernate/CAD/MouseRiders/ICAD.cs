
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
 * Clase i:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class ICAD : BasicCAD, IICAD
{
public ICAD() : base ()
{
}

public ICAD(ISession sessionAux) : base (sessionAux)
{
}



public IEN ReadOIDDefault (int id
                           )
{
        IEN iEN = null;

        try
        {
                SessionInitializeTransaction ();
                iEN = (IEN)session.Get (typeof(IEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iEN;
}

public System.Collections.Generic.IList<IEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IEN>();
                        else
                                result = session.CreateCriteria (typeof(IEN)).List<IEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IEN i)
{
        try
        {
                SessionInitializeTransaction ();
                IEN iEN = (IEN)session.Load (typeof(IEN), i.Id);



                iEN.UsuarioBloqueado = i.UsuarioBloqueado;


                iEN.FechaInicio = i.FechaInicio;


                iEN.FechaFin = i.FechaFin;

                session.Update (iEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearBloqueo (IEN i)
{
        try
        {
                SessionInitializeTransaction ();
                if (i.Contiene != null) {
                        for (int i = 0; i < i.Contiene.Count; i++) {
                                i.Contiene [i] = (MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN), i.Contiene [i].Id);
                                i.Contiene [i].Pertenece = i;
                        }
                }

                session.Save (i);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return i.Id;
}

public void ModificarBloqueo (IEN i)
{
        try
        {
                SessionInitializeTransaction ();
                IEN iEN = (IEN)session.Load (typeof(IEN), i.Id);

                iEN.UsuarioBloqueado = i.UsuarioBloqueado;


                iEN.FechaInicio = i.FechaInicio;


                iEN.FechaFin = i.FechaFin;

                session.Update (iEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
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
                IEN iEN = (IEN)session.Load (typeof(IEN), id);
                session.Delete (iEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IEN
public IEN ReadOID (int id
                    )
{
        IEN iEN = null;

        try
        {
                SessionInitializeTransaction ();
                iEN = (IEN)session.Get (typeof(IEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iEN;
}

public System.Collections.Generic.IList<IEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IEN>();
                else
                        result = session.CreateCriteria (typeof(IEN)).List<IEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ICAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
