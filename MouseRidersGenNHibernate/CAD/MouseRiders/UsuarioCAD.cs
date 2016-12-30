
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
 * Clase Usuario:
 *
 */

namespace MRModel.CAD
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (int id
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);

                usuarioEN.Email = usuario.Email;


                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Pais = usuario.Pais;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Puntuacion = usuario.Puntuacion;





                usuarioEN.FechaRegistro = usuario.FechaRegistro;





                usuarioEN.Contrasenya = usuario.Contrasenya;



                usuarioEN.Nombreusuario = usuario.Nombreusuario;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearUsuario (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Id;
}

public void ModificarUsuario (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);

                usuarioEN.Email = usuario.Email;


                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Pais = usuario.Pais;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Puntuacion = usuario.Puntuacion;


                usuarioEN.FechaRegistro = usuario.FechaRegistro;


                usuarioEN.Contrasenya = usuario.Contrasenya;


                usuarioEN.Nombreusuario = usuario.Nombreusuario;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarUsuario (int id
                           )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), id);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: UsuarioEN
public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void RelacionaPermiso (int p_Usuario_OID, System.Collections.Generic.IList<MRModel.EN.PermisoEN_OID> p_tiene_OIDs)
{
        MRModel.EN.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                MRModel.EN.PermisoEN tieneENAux = null;
                if (usuarioEN.Tiene == null) {
                        usuarioEN.Tiene = new System.Collections.Generic.List<MRModel.EN.PermisoEN>();
                }

                foreach (MRModel.EN.PermisoEN_OID item in p_tiene_OIDs) {
                        tieneENAux = new MRModel.EN.PermisoEN ();
                        tieneENAux = (MRModel.EN.PermisoEN)session.Load (typeof(MRModel.EN.PermisoEN), item);
                        tieneENAux.Pertenece.Add (usuarioEN);

                        usuarioEN.Tiene.Add (tieneENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaRecompensa (int p_Usuario_OID, System.Collections.Generic.IList<int> p_obtiene_OIDs)
{
        MRModel.EN.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                MRModel.EN.RecompensaEN obtieneENAux = null;
                if (usuarioEN.Obtiene == null) {
                        usuarioEN.Obtiene = new System.Collections.Generic.List<MRModel.EN.RecompensaEN>();
                }

                foreach (int item in p_obtiene_OIDs) {
                        obtieneENAux = new MRModel.EN.RecompensaEN ();
                        obtieneENAux = (MRModel.EN.RecompensaEN)session.Load (typeof(MRModel.EN.RecompensaEN), item);
                        obtieneENAux.Otorgada.Add (usuarioEN);

                        usuarioEN.Obtiene.Add (obtieneENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaDenuncia (int p_Usuario_OID, System.Collections.Generic.IList<int> p_creaD_OIDs)
{
        MRModel.EN.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                MRModel.EN.DenunciaEN creaDENAux = null;
                if (usuarioEN.CreaD == null) {
                        usuarioEN.CreaD = new System.Collections.Generic.List<MRModel.EN.DenunciaEN>();
                }

                foreach (int item in p_creaD_OIDs) {
                        creaDENAux = new MRModel.EN.DenunciaEN ();
                        creaDENAux = (MRModel.EN.DenunciaEN)session.Load (typeof(MRModel.EN.DenunciaEN), item);
                        creaDENAux.Es_creada = usuarioEN;

                        usuarioEN.CreaD.Add (creaDENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaBloqueo (int p_Usuario_OID, int p_es_de_OID)
{
        MRModel.EN.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                usuarioEN.Es_de = (MRModel.EN.BloqueoEN)session.Load (typeof(MRModel.EN.BloqueoEN), p_es_de_OID);

                usuarioEN.Es_de.Pertenece = usuarioEN;




                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<MRModel.EN.UsuarioEN> ReadFilter (string p_nombre)
{
        System.Collections.Generic.IList<MRModel.EN.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where FROM UsuarioEN where :p_nombre like nombreusuario or :p_nombre like nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENreadFilterHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<MRModel.EN.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
