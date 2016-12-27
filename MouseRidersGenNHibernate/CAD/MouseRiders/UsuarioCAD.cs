
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
 * Clase Usuario:
 *
 */

namespace MouseRidersGenNHibernate.CAD.MouseRiders
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void RelacionaPermiso (int p_Usuario_OID, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID> p_tiene_OIDs)
{
        MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN tieneENAux = null;
                if (usuarioEN.Tiene == null) {
                        usuarioEN.Tiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN>();
                }

                foreach (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN_OID item in p_tiene_OIDs) {
                        tieneENAux = new MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN ();
                        tieneENAux = (MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.PermisoEN), item);
                        tieneENAux.Pertenece.Add (usuarioEN);

                        usuarioEN.Tiene.Add (tieneENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaRecompensa (int p_Usuario_OID, System.Collections.Generic.IList<int> p_obtiene_OIDs)
{
        MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN obtieneENAux = null;
                if (usuarioEN.Obtiene == null) {
                        usuarioEN.Obtiene = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN>();
                }

                foreach (int item in p_obtiene_OIDs) {
                        obtieneENAux = new MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN ();
                        obtieneENAux = (MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.RecompensaEN), item);
                        obtieneENAux.Otorgada.Add (usuarioEN);

                        usuarioEN.Obtiene.Add (obtieneENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaDenuncia (int p_Usuario_OID, System.Collections.Generic.IList<int> p_creaD_OIDs)
{
        MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN creaDENAux = null;
                if (usuarioEN.CreaD == null) {
                        usuarioEN.CreaD = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN>();
                }

                foreach (int item in p_creaD_OIDs) {
                        creaDENAux = new MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN ();
                        creaDENAux = (MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.DenunciaEN), item);
                        creaDENAux.Es_creada = usuarioEN;

                        usuarioEN.CreaD.Add (creaDENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelacionaBloqueo (int p_Usuario_OID, int p_es_de_OID)
{
        MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                usuarioEN.Es_de = (MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN)session.Load (typeof(MouseRidersGenNHibernate.EN.MouseRiders.BloqueoEN), p_es_de_OID);

                usuarioEN.Es_de.Pertenece = usuarioEN;




                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MouseRidersGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MouseRidersGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
