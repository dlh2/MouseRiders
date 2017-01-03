
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
 * Clase Permiso:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class PermisoCAD : BasicCAD, IPermisoCAD
{
public PermisoCAD() : base ()
{
}

public PermisoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PermisoEN ReadOIDDefault (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID CrearPermiso (PermisoEN permiso)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (permiso);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPermiso (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PermisoEN
public PermisoEN ReadOID (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID permisoEN_OID
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> ReadFilter (MouseRidersGenNHibernate.Enumerated.MouseRiders.T_RolEnum? p_rol, string p_permiso)
{
        System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PermisoEN self where FROM PermisoEN where (:p_rol is null or :p_rol=rol) and (:p_permiso is null or :p_permiso like permiso)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PermisoENreadFilterHQL");
                query.SetParameter ("p_rol", p_rol);
                query.SetParameter ("p_permiso", p_permiso);

                result = query.List<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in PermisoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
