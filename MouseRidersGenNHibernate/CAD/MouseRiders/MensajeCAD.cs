
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
 * Clase Mensaje:
 *
 */

namespace MRModel.CAD
{
public partial class MensajeCAD : BasicCAD, IMensajeCAD
{
public MensajeCAD() : base ()
{
}

public MensajeCAD(ISession sessionAux) : base (sessionAux)
{
}



public MensajeEN ReadOIDDefault (int id
                                 )
{
        MensajeEN mensajeEN = null;

        try
        {
                SessionInitializeTransaction ();
                mensajeEN = (MensajeEN)session.Get (typeof(MensajeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mensajeEN;
}

public System.Collections.Generic.IList<MensajeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MensajeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MensajeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MensajeEN>();
                        else
                                result = session.CreateCriteria (typeof(MensajeEN)).List<MensajeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MensajeEN mensaje)
{
        try
        {
                SessionInitializeTransaction ();
                MensajeEN mensajeEN = (MensajeEN)session.Load (typeof(MensajeEN), mensaje.Id);

                mensajeEN.Asunto = mensaje.Asunto;


                mensajeEN.Texto = mensaje.Texto;


                mensajeEN.Adjunto = mensaje.Adjunto;


                mensajeEN.Tipo = mensaje.Tipo;




                session.Update (mensajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearMensaje (MensajeEN mensaje)
{
        try
        {
                SessionInitializeTransaction ();
                if (mensaje.Es_enviado != null) {
                        // Argumento OID y no colección.
                        mensaje.Es_enviado = (MRModel.EN.UsuarioEN)session.Load (typeof(MRModel.EN.UsuarioEN), mensaje.Es_enviado.Id);

                        mensaje.Es_enviado.Envia
                        .Add (mensaje);
                }
                if (mensaje.Es_recibido != null) {
                        for (int i = 0; i < mensaje.Es_recibido.Count; i++) {
                                mensaje.Es_recibido [i] = (MRModel.EN.UsuarioEN)session.Load (typeof(MRModel.EN.UsuarioEN), mensaje.Es_recibido [i].Id);
                                mensaje.Es_recibido [i].Recibe.Add (mensaje);
                        }
                }

                session.Save (mensaje);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mensaje.Id;
}

public void ModificarMensaje (MensajeEN mensaje)
{
        try
        {
                SessionInitializeTransaction ();
                MensajeEN mensajeEN = (MensajeEN)session.Load (typeof(MensajeEN), mensaje.Id);

                mensajeEN.Asunto = mensaje.Asunto;


                mensajeEN.Texto = mensaje.Texto;


                mensajeEN.Adjunto = mensaje.Adjunto;


                mensajeEN.Tipo = mensaje.Tipo;

                session.Update (mensajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarMensaje (int id
                           )
{
        try
        {
                SessionInitializeTransaction ();
                MensajeEN mensajeEN = (MensajeEN)session.Load (typeof(MensajeEN), id);
                session.Delete (mensajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MensajeEN
public MensajeEN ReadOID (int id
                          )
{
        MensajeEN mensajeEN = null;

        try
        {
                SessionInitializeTransaction ();
                mensajeEN = (MensajeEN)session.Get (typeof(MensajeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mensajeEN;
}

public System.Collections.Generic.IList<MensajeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MensajeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MensajeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MensajeEN>();
                else
                        result = session.CreateCriteria (typeof(MensajeEN)).List<MensajeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void RelacionaMensaje (int p_Mensaje_OID, int p_es_enviadoN_OID)
{
        MRModel.EN.MensajeEN mensajeEN = null;
        try
        {
                SessionInitializeTransaction ();
                mensajeEN = (MensajeEN)session.Load (typeof(MensajeEN), p_Mensaje_OID);
                mensajeEN.Es_enviadoN = (MRModel.EN.ControladorNotificacionesEN)session.Load (typeof(MRModel.EN.ControladorNotificacionesEN), p_es_enviadoN_OID);

                mensajeEN.Es_enviadoN.EnviaN.Add (mensajeEN);



                session.Update (mensajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<MRModel.EN.MensajeEN> ReadFilter (MRModel.Enumerated.T_MensajeEnum? p_tipo, string p_asunto)
{
        System.Collections.Generic.IList<MRModel.EN.MensajeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MensajeEN self where FROM MensajeEN where (:p_asunto is null or :p_asunto like asunto) and (:p_tipo is null or :p_tipo=tipo)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MensajeENreadFilterHQL");
                query.SetParameter ("p_tipo", p_tipo);
                query.SetParameter ("p_asunto", p_asunto);

                result = query.List<MRModel.EN.MensajeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MRModel.Exceptions.ModelException)
                        throw ex;
                throw new MRModel.Exceptions.DataLayerException ("Error in MensajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
