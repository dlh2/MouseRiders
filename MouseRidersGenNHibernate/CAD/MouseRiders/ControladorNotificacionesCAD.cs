
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
 * Clase ControladorNotificaciones:
 *
 */

namespace MRModel.CAD
{
public partial class ControladorNotificacionesCAD : BasicCAD, IControladorNotificacionesCAD
{
public ControladorNotificacionesCAD() : base ()
{
}

public ControladorNotificacionesCAD(ISession sessionAux) : base (sessionAux)
{
}



public ControladorNotificacionesEN ReadOIDDefault (int id
                                                   )
{
        ControladorNotificacionesEN controladorNotificacionesEN = null;

        try
        {
                SessionInitializeTransaction ();
                controladorNotificacionesEN = (ControladorNotificacionesEN)session.Get (typeof(ControladorNotificacionesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return controladorNotificacionesEN;
}

public System.Collections.Generic.IList<ControladorNotificacionesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ControladorNotificacionesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ControladorNotificacionesEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ControladorNotificacionesEN>();
                        else
                                result = session.CreateCriteria (typeof(ControladorNotificacionesEN)).List<ControladorNotificacionesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ControladorNotificacionesEN controladorNotificaciones)
{
        try
        {
                SessionInitializeTransaction ();
                ControladorNotificacionesEN controladorNotificacionesEN = (ControladorNotificacionesEN)session.Load (typeof(ControladorNotificacionesEN), controladorNotificaciones.Id);

                session.Update (controladorNotificacionesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearCNotificaciones (ControladorNotificacionesEN controladorNotificaciones)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (controladorNotificaciones);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return controladorNotificaciones.Id;
}

public void ModificarCNotificaciones (ControladorNotificacionesEN controladorNotificaciones)
{
        try
        {
                SessionInitializeTransaction ();
                ControladorNotificacionesEN controladorNotificacionesEN = (ControladorNotificacionesEN)session.Load (typeof(ControladorNotificacionesEN), controladorNotificaciones.Id);
                session.Update (controladorNotificacionesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarCNotificaciones (int id
                                   )
{
        try
        {
                SessionInitializeTransaction ();
                ControladorNotificacionesEN controladorNotificacionesEN = (ControladorNotificacionesEN)session.Load (typeof(ControladorNotificacionesEN), id);
                session.Delete (controladorNotificacionesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ControladorNotificacionesEN
public ControladorNotificacionesEN ReadOID (int id
                                            )
{
        ControladorNotificacionesEN controladorNotificacionesEN = null;

        try
        {
                SessionInitializeTransaction ();
                controladorNotificacionesEN = (ControladorNotificacionesEN)session.Get (typeof(ControladorNotificacionesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return controladorNotificacionesEN;
}

public System.Collections.Generic.IList<ControladorNotificacionesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ControladorNotificacionesEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ControladorNotificacionesEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ControladorNotificacionesEN>();
                else
                        result = session.CreateCriteria (typeof(ControladorNotificacionesEN)).List<ControladorNotificacionesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in ControladorNotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
