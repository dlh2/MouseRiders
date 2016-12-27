
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
 * Clase Hilo:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class HiloCAD : BasicCAD, IHiloCAD
{
public HiloCAD() : base ()
{
}

public HiloCAD(ISession sessionAux) : base (sessionAux)
{
}



public HiloEN ReadOIDDefault (int id
                              )
{
        HiloEN hiloEN = null;

        try
        {
                SessionInitializeTransaction ();
                hiloEN = (HiloEN)session.Get (typeof(HiloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return hiloEN;
}

public System.Collections.Generic.IList<HiloEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<HiloEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(HiloEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<HiloEN>();
                        else
                                result = session.CreateCriteria (typeof(HiloEN)).List<HiloEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (HiloEN hilo)
{
        try
        {
                SessionInitializeTransaction ();
                HiloEN hiloEN = (HiloEN)session.Load (typeof(HiloEN), hilo.Id);

                hiloEN.Creador = hilo.Creador;


                hiloEN.Fecha = hilo.Fecha;


                hiloEN.NumComentarios = hilo.NumComentarios;



                hiloEN.Titulo = hilo.Titulo;

                session.Update (hiloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearHilo (HiloEN hilo)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (hilo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return hilo.Id;
}

public void ModificarHilo (HiloEN hilo)
{
        try
        {
                SessionInitializeTransaction ();
                HiloEN hiloEN = (HiloEN)session.Load (typeof(HiloEN), hilo.Id);

                hiloEN.Creador = hilo.Creador;


                hiloEN.Fecha = hilo.Fecha;


                hiloEN.NumComentarios = hilo.NumComentarios;


                hiloEN.Titulo = hilo.Titulo;

                session.Update (hiloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarHilo (int id
                        )
{
        try
        {
                SessionInitializeTransaction ();
                HiloEN hiloEN = (HiloEN)session.Load (typeof(HiloEN), id);
                session.Delete (hiloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: HiloEN
public HiloEN ReadOID (int id
                       )
{
        HiloEN hiloEN = null;

        try
        {
                SessionInitializeTransaction ();
                hiloEN = (HiloEN)session.Get (typeof(HiloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return hiloEN;
}

public System.Collections.Generic.IList<HiloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<HiloEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(HiloEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<HiloEN>();
                else
                        result = session.CreateCriteria (typeof(HiloEN)).List<HiloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in HiloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
