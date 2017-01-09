
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
 * Clase Articulo:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
{
public partial class ArticuloCAD : BasicCAD, IArticuloCAD
{
public ArticuloCAD() : base ()
{
}

public ArticuloCAD(ISession sessionAux) : base (sessionAux)
{
}



public ArticuloEN ReadOIDDefault (int id
                                  )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ArticuloEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                        else
                                result = session.CreateCriteria (typeof(ArticuloEN)).List<ArticuloEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), articulo.Id);


                articuloEN.Titulo = articulo.Titulo;


                articuloEN.Autor = articulo.Autor;


                articuloEN.Contenido = articulo.Contenido;


                articuloEN.ContenidoDescargable = articulo.ContenidoDescargable;


                articuloEN.Puntuacion = articulo.Puntuacion;


                articuloEN.Fecha = articulo.Fecha;



                articuloEN.Contador = articulo.Contador;


                articuloEN.Subtitulo = articulo.Subtitulo;


                articuloEN.Portada = articulo.Portada;


                articuloEN.Descripcion = articulo.Descripcion;

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearArticulo (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                if (articulo.Pertenece != null) {
                        // Argumento OID y no colección.
                        articulo.Pertenece = (MouseRidersGenNHibernate.EN.MouseRiders.SeccionEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.SeccionEN), articulo.Pertenece.Seccion);

                        articulo.Pertenece.Tiene
                        .Add (articulo);
                }

                session.Save (articulo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articulo.Id;
}

public void ModificarArticulo (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), articulo.Id);

                articuloEN.Titulo = articulo.Titulo;


                articuloEN.Autor = articulo.Autor;


                articuloEN.Contenido = articulo.Contenido;


                articuloEN.ContenidoDescargable = articulo.ContenidoDescargable;


                articuloEN.Puntuacion = articulo.Puntuacion;


                articuloEN.Fecha = articulo.Fecha;


                articuloEN.Contador = articulo.Contador;


                articuloEN.Subtitulo = articulo.Subtitulo;


                articuloEN.Portada = articulo.Portada;


                articuloEN.Descripcion = articulo.Descripcion;

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarArticulo (int id
                            )
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), id);
                session.Delete (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ArticuloEN
public ArticuloEN ReadOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ArticuloEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                else
                        result = session.CreateCriteria (typeof(ArticuloEN)).List<ArticuloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> ReadFilter (string p_nombre, Nullable<DateTime> p_fecha, bool? p_mayor, float? p_puntuacion, bool ? p_mayor1)
{
        System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ArticuloEN self where FROM ArticuloEN where (:p_nombre is null or :p_nombre like '%titulo%' or :p_nombre like '%descripcion%') and (:p_fecha is null or (:p_mayor is true and :p_fecha>=fecha) or (:p_mayor is false and :p_fecha<=fecha)) and (:p_puntuacion is null or (:p_mayor1 is true and :p_puntuacion>=puntuacion) or (:p_mayor1 is false and :p_puntuacion<=puntuacion))";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ArticuloENreadFilterHQL");
                query.SetParameter("p_nombre", "%" + p_nombre + "%");
                //query.SetParameter ("p_fecha", p_fecha);
                //query.SetParameter ("p_mayor", p_mayor);
                //query.SetParameter ("p_puntuacion", p_puntuacion);
                //query.SetParameter ("p_mayor1", p_mayor1);

                result = query.List<MouseRidersGenNHibernate.EN.MouseRiders.ArticuloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
