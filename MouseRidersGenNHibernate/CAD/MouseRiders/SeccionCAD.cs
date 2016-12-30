
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
 * Clase Seccion:
 *
 */

namespace MRModel.CAD
{
public partial class SeccionCAD : BasicCAD, ISeccionCAD
{
public SeccionCAD() : base ()
{
}

public SeccionCAD(ISession sessionAux) : base (sessionAux)
{
}



public SeccionEN ReadOIDDefault (int seccion
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
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


                seccionEN.Nombre = seccion.Nombre;

                session.Update (seccionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearSeccion (SeccionEN seccion)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (seccion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
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

                seccionEN.Nombre = seccion.Nombre;

                session.Update (seccionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarSeccion (int seccion
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SeccionEN
public SeccionEN ReadOID (int seccion
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
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
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public MRModel.EN.SeccionEN ReadFilter (string p_nombre)
{
        MRModel.EN.SeccionEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SeccionEN self where FROM SeccionEN where :p_nombre=nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SeccionENreadFilterHQL");
                query.SetParameter ("p_nombre", p_nombre);


                result = query.UniqueResult<MRModel.EN.SeccionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in SeccionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
