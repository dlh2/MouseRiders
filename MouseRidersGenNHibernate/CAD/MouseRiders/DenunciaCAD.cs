
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
 * Clase Denuncia:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class DenunciaCAD : BasicCAD, IDenunciaCAD
{
public DenunciaCAD() : base ()
{
}

public DenunciaCAD(ISession sessionAux) : base (sessionAux)
{
}



public DenunciaEN ReadOIDDefault (int id
                                  )
{
        DenunciaEN denunciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                denunciaEN = (DenunciaEN)session.Get (typeof(DenunciaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return denunciaEN;
}

public System.Collections.Generic.IList<DenunciaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DenunciaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DenunciaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DenunciaEN>();
                        else
                                result = session.CreateCriteria (typeof(DenunciaEN)).List<DenunciaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DenunciaEN denuncia)
{
        try
        {
                SessionInitializeTransaction ();
                DenunciaEN denunciaEN = (DenunciaEN)session.Load (typeof(DenunciaEN), denuncia.Id);

                denunciaEN.Motivo = denuncia.Motivo;




                denunciaEN.Fecha = denuncia.Fecha;


                session.Update (denunciaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearDenuncia (DenunciaEN denuncia)
{
        try
        {
                SessionInitializeTransaction ();
                if (denuncia.Es_creada != null) {
                        // Argumento OID y no colección.
                        denuncia.Es_creada = (MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN), denuncia.Es_creada.Id);

                        denuncia.Es_creada.CreaD
                        .Add (denuncia);
                }
                if (denuncia.Es_recibida != null) {
                        // Argumento OID y no colección.
                        denuncia.Es_recibida = (MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN), denuncia.Es_recibida.Id);

                        denuncia.Es_recibida.RecibeD
                        .Add (denuncia);
                }

                session.Save (denuncia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return denuncia.Id;
}

public void ModificarDenuncia (DenunciaEN denuncia)
{
        try
        {
                SessionInitializeTransaction ();
                DenunciaEN denunciaEN = (DenunciaEN)session.Load (typeof(DenunciaEN), denuncia.Id);

                denunciaEN.Motivo = denuncia.Motivo;


                denunciaEN.Fecha = denuncia.Fecha;

                session.Update (denunciaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarDenuncia (int id
                            )
{
        try
        {
                SessionInitializeTransaction ();
                DenunciaEN denunciaEN = (DenunciaEN)session.Load (typeof(DenunciaEN), id);
                session.Delete (denunciaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DenunciaEN
public DenunciaEN ReadOID (int id
                           )
{
        DenunciaEN denunciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                denunciaEN = (DenunciaEN)session.Get (typeof(DenunciaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return denunciaEN;
}

public System.Collections.Generic.IList<DenunciaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DenunciaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DenunciaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DenunciaEN>();
                else
                        result = session.CreateCriteria (typeof(DenunciaEN)).List<DenunciaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in DenunciaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
