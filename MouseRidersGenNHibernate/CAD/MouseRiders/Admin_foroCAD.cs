
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
 * Clase Admin_foro:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class Admin_foroCAD : BasicCAD, IAdmin_foroCAD
{
public Admin_foroCAD() : base ()
{
}

public Admin_foroCAD(ISession sessionAux) : base (sessionAux)
{
}



public Admin_foroEN ReadOIDDefault (int id
                                    )
{
        Admin_foroEN admin_foroEN = null;

        try
        {
                SessionInitializeTransaction ();
                admin_foroEN = (Admin_foroEN)session.Get (typeof(Admin_foroEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return admin_foroEN;
}

public System.Collections.Generic.IList<Admin_foroEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Admin_foroEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Admin_foroEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<Admin_foroEN>();
                        else
                                result = session.CreateCriteria (typeof(Admin_foroEN)).List<Admin_foroEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Admin_foroEN admin_foro)
{
        try
        {
                SessionInitializeTransaction ();
                Admin_foroEN admin_foroEN = (Admin_foroEN)session.Load (typeof(Admin_foroEN), admin_foro.Id);
                session.Update (admin_foroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearAdmin_foro (Admin_foroEN admin_foro)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (admin_foro);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return admin_foro.Id;
}

public void ModificarAdmin_foro (Admin_foroEN admin_foro)
{
        try
        {
                SessionInitializeTransaction ();
                Admin_foroEN admin_foroEN = (Admin_foroEN)session.Load (typeof(Admin_foroEN), admin_foro.Id);

                admin_foroEN.Email = admin_foro.Email;


                admin_foroEN.Nombre = admin_foro.Nombre;


                admin_foroEN.Apellidos = admin_foro.Apellidos;


                admin_foroEN.Pais = admin_foro.Pais;


                admin_foroEN.Telefono = admin_foro.Telefono;


                admin_foroEN.Puntuacion = admin_foro.Puntuacion;


                admin_foroEN.FechaRegistro = admin_foro.FechaRegistro;


                admin_foroEN.Contrasenya = admin_foro.Contrasenya;


                admin_foroEN.Nombreusuario = admin_foro.Nombreusuario;

                session.Update (admin_foroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarAdmin_foro (int id
                              )
{
        try
        {
                SessionInitializeTransaction ();
                Admin_foroEN admin_foroEN = (Admin_foroEN)session.Load (typeof(Admin_foroEN), id);
                session.Delete (admin_foroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: Admin_foroEN
public Admin_foroEN ReadOID (int id
                             )
{
        Admin_foroEN admin_foroEN = null;

        try
        {
                SessionInitializeTransaction ();
                admin_foroEN = (Admin_foroEN)session.Get (typeof(Admin_foroEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return admin_foroEN;
}

public System.Collections.Generic.IList<Admin_foroEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Admin_foroEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(Admin_foroEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<Admin_foroEN>();
                else
                        result = session.CreateCriteria (typeof(Admin_foroEN)).List<Admin_foroEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in Admin_foroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
