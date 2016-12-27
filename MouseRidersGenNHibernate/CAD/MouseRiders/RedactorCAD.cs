
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
 * Clase Redactor:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class RedactorCAD : BasicCAD, IRedactorCAD
{
public RedactorCAD() : base ()
{
}

public RedactorCAD(ISession sessionAux) : base (sessionAux)
{
}



public RedactorEN ReadOIDDefault (int id
                                  )
{
        RedactorEN redactorEN = null;

        try
        {
                SessionInitializeTransaction ();
                redactorEN = (RedactorEN)session.Get (typeof(RedactorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return redactorEN;
}

public System.Collections.Generic.IList<RedactorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RedactorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RedactorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RedactorEN>();
                        else
                                result = session.CreateCriteria (typeof(RedactorEN)).List<RedactorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RedactorEN redactor)
{
        try
        {
                SessionInitializeTransaction ();
                RedactorEN redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), redactor.Id);
                session.Update (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearRedactor (RedactorEN redactor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (redactor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return redactor.Id;
}

public void ModificarRedactor (RedactorEN redactor)
{
        try
        {
                SessionInitializeTransaction ();
                RedactorEN redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), redactor.Id);

                redactorEN.Email = redactor.Email;


                redactorEN.Nombre = redactor.Nombre;


                redactorEN.Apellidos = redactor.Apellidos;


                redactorEN.Pais = redactor.Pais;


                redactorEN.Telefono = redactor.Telefono;


                redactorEN.Puntuacion = redactor.Puntuacion;


                redactorEN.FechaRegistro = redactor.FechaRegistro;


                redactorEN.Contrasenya = redactor.Contrasenya;


                redactorEN.Nombreusuario = redactor.Nombreusuario;

                session.Update (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarRedactor (int id
                            )
{
        try
        {
                SessionInitializeTransaction ();
                RedactorEN redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), id);
                session.Delete (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RedactorEN
public RedactorEN ReadOID (int id
                           )
{
        RedactorEN redactorEN = null;

        try
        {
                SessionInitializeTransaction ();
                redactorEN = (RedactorEN)session.Get (typeof(RedactorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return redactorEN;
}

public System.Collections.Generic.IList<RedactorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RedactorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RedactorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RedactorEN>();
                else
                        result = session.CreateCriteria (typeof(RedactorEN)).List<RedactorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
