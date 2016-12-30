
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
 * Clase Permiso:
 *
 */

namespace MRModel.CAD
{
public partial class PermisoCAD : BasicCAD, IPermisoCAD
{
public PermisoCAD() : base ()
{
}

public PermisoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PermisoEN ReadOIDDefault (MRModel.EN.PermisoEN_OID permisoEN_OID
                                 )
{
        PermisoEN permisoEN = null;

        try
        {
                SessionInitializeTransaction ();
                permisoEN = (PermisoEN)session.Get (typeof(PermisoEN), permisoEN_OID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return permisoEN;
}

public System.Collections.Generic.IList<PermisoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PermisoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PermisoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PermisoEN>();
                        else
                                result = session.CreateCriteria (typeof(PermisoEN)).List<PermisoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PermisoEN permiso)
{
        try
        {
                SessionInitializeTransaction ();
                PermisoEN permisoEN = (PermisoEN)session.Load (typeof(PermisoEN), permiso.PermisoOID);

                permisoEN.Permisos = permiso.Permisos;


                session.Update (permisoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public MRModel.EN.PermisoEN_OID CrearPermiso (PermisoEN permiso)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (permiso);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return permiso.PermisoOID;
}

public void ModificarPermiso (PermisoEN permiso)
{
        try
        {
                SessionInitializeTransaction ();
                PermisoEN permisoEN = (PermisoEN)session.Load (typeof(PermisoEN), permiso.PermisoOID);

                permisoEN.Permisos = permiso.Permisos;

                session.Update (permisoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPermiso (MRModel.EN.PermisoEN_OID permisoEN_OID
                           )
{
        try
        {
                SessionInitializeTransaction ();
                PermisoEN permisoEN = (PermisoEN)session.Load (typeof(PermisoEN), permisoEN_OID);
                session.Delete (permisoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PermisoEN
public PermisoEN ReadOID (MRModel.EN.PermisoEN_OID permisoEN_OID
                          )
{
        PermisoEN permisoEN = null;

        try
        {
                SessionInitializeTransaction ();
                permisoEN = (PermisoEN)session.Get (typeof(PermisoEN), permisoEN_OID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return permisoEN;
}

public System.Collections.Generic.IList<PermisoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PermisoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PermisoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PermisoEN>();
                else
                        result = session.CreateCriteria (typeof(PermisoEN)).List<PermisoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<MRModel.EN.PermisoEN> ReadFilter (MRModel.Enumerated.T_RolEnum? p_rol, string p_permiso)
{
        System.Collections.Generic.IList<MRModel.EN.PermisoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PermisoEN self where FROM PermisoEN where (:p_rol is null or :p_rol=rol) and (:p_permiso is null or :p_permiso like permiso)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PermisoENreadFilterHQL");
                query.SetParameter ("p_rol", p_rol);
                query.SetParameter ("p_permiso", p_permiso);

                result = query.List<MRModel.EN.PermisoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
