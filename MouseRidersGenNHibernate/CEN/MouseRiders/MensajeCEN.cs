

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MRModel.Exceptions;

using MRModel.EN;
using MRModel.CAD;


namespace MRModel.CEN
{
/*
 *      Definition of the class MensajeCEN
 *
 */
public partial class MensajeCEN
{
private IMensajeCAD _IMensajeCAD;

public MensajeCEN()
{
        this._IMensajeCAD = new MensajeCAD ();
}

public MensajeCEN(IMensajeCAD _IMensajeCAD)
{
        this._IMensajeCAD = _IMensajeCAD;
}

public IMensajeCAD get_IMensajeCAD ()
{
        return this._IMensajeCAD;
}

public int CrearMensaje (string p_asunto, string p_texto, string p_adjunto, MRModel.Enumerated.T_MensajeEnum p_tipo, int p_es_enviado, System.Collections.Generic.IList<int> p_es_recibido)
{
        MensajeEN mensajeEN = null;
        int oid;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.Asunto = p_asunto;

        mensajeEN.Texto = p_texto;

        mensajeEN.Adjunto = p_adjunto;

        mensajeEN.Tipo = p_tipo;


        if (p_es_enviado != -1) {
                // El argumento p_es_enviado -> Property es_enviado es oid = false
                // Lista de oids id
                mensajeEN.Es_enviado = new MRModel.EN.UsuarioEN ();
                mensajeEN.Es_enviado.Id = p_es_enviado;
        }


        mensajeEN.Es_recibido = new System.Collections.Generic.List<MRModel.EN.UsuarioEN>();
        if (p_es_recibido != null) {
                foreach (int item in p_es_recibido) {
                        MRModel.EN.UsuarioEN en = new MRModel.EN.UsuarioEN ();
                        en.Id = item;
                        mensajeEN.Es_recibido.Add (en);
                }
        }

        else{
                mensajeEN.Es_recibido = new System.Collections.Generic.List<MRModel.EN.UsuarioEN>();
        }

        //Call to MensajeCAD

        oid = _IMensajeCAD.CrearMensaje (mensajeEN);
        return oid;
}

public void ModificarMensaje (int p_Mensaje_OID, string p_asunto, string p_texto, string p_adjunto, MRModel.Enumerated.T_MensajeEnum p_tipo)
{
        MensajeEN mensajeEN = null;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.Id = p_Mensaje_OID;
        mensajeEN.Asunto = p_asunto;
        mensajeEN.Texto = p_texto;
        mensajeEN.Adjunto = p_adjunto;
        mensajeEN.Tipo = p_tipo;
        //Call to MensajeCAD

        _IMensajeCAD.ModificarMensaje (mensajeEN);
}

public void BorrarMensaje (int id
                           )
{
        _IMensajeCAD.BorrarMensaje (id);
}

public MensajeEN ReadOID (int id
                          )
{
        MensajeEN mensajeEN = null;

        mensajeEN = _IMensajeCAD.ReadOID (id);
        return mensajeEN;
}

public System.Collections.Generic.IList<MensajeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MensajeEN> list = null;

        list = _IMensajeCAD.ReadAll (first, size);
        return list;
}
public void RelacionaMensaje (int p_Mensaje_OID, int p_es_enviadoN_OID)
{
        //Call to MensajeCAD

        _IMensajeCAD.RelacionaMensaje (p_Mensaje_OID, p_es_enviadoN_OID);
}
public System.Collections.Generic.IList<MRModel.EN.MensajeEN> ReadFilter (MRModel.Enumerated.T_MensajeEnum? p_tipo, string p_asunto)
{
        return _IMensajeCAD.ReadFilter (p_tipo, p_asunto);
}
}
}
