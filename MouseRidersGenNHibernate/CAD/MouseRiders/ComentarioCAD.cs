
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
 * Clase Comentario:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class ComentarioCAD : BasicCAD, IComentarioCAD
{
public ComentarioCAD() : base ()
{
}

public ComentarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ComentarioEN ReadOIDDefault (int id
                                    )
{
        ComentarioEN comentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Get (typeof(ComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ComentarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ComentarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ComentarioEN)).List<ComentarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), comentario.Id);

                comentarioEN.Creador = comentario.Creador;


                comentarioEN.Fecha = comentario.Fecha;


                comentarioEN.Contenido = comentario.Contenido;


                comentarioEN.Valoracion = comentario.Valoracion;



                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearComentario (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (comentario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentario.Id;
}

public void ModificarComentario (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), comentario.Id);

                comentarioEN.Creador = comentario.Creador;


                comentarioEN.Fecha = comentario.Fecha;


                comentarioEN.Contenido = comentario.Contenido;


                comentarioEN.Valoracion = comentario.Valoracion;

                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarComentario (int id
                              )
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), id);
                session.Delete (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaArticulo (int p_Comentario_OID, int p_pertenece_OID)
{
        MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN comentarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), p_Comentario_OID);
                comentarioEN.Pertenece = (MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN), p_pertenece_OID);

                comentarioEN.Pertenece.Tiene.Add (comentarioEN);



                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaHilo (int p_Comentario_OID, int p_pertenece_a_OID)
{
        MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN comentarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), p_Comentario_OID);
                comentarioEN.Pertenece_a = (MouseRidersGenNHibernate.EN.MouseRiders.HiloEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.HiloEN), p_pertenece_a_OID);

                comentarioEN.Pertenece_a.Contiene.Add (comentarioEN);



                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public int NumComentsArticulo (int ? p_id)
{
        int result;

        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ComentarioEN self where SELECT count(*) FROM ComentarioEN where :p_id=pertenece";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ComentarioENnumComentsArticuloHQL");
                query.SetParameter ("p_id", p_id);


                result = query.UniqueResult<int>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public int NumComentsHilo (int ? p_id)
{
        int result;

        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ComentarioEN self where SELECT count(*) FROM ComentarioEN where :p_id=pertenece_a";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ComentarioENnumComentsHiloHQL");
                query.SetParameter ("p_id", p_id);


                result = query.UniqueResult<int>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
//Sin e: ReadOID
//Con e: ComentarioEN
public ComentarioEN ReadOID (int id
                             )
{
        ComentarioEN comentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Get (typeof(ComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ComentarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ComentarioEN>();
                else
                        result = session.CreateCriteria (typeof(ComentarioEN)).List<ComentarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
