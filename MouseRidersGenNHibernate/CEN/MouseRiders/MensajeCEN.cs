

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.Exceptions;

using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;


namespace MouseRidersGenNHibernate.CEN.MouseRiders
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

public int CrearMensaje (string p_asunto, string p_texto, string p_adjunto, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum p_tipo, int p_es_enviado, System.Collections.Generic.IList<int> p_es_recibido)
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
                mensajeEN.Es_enviado = new MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN ();
                mensajeEN.Es_enviado.Id = p_es_enviado;
        }


        mensajeEN.Es_recibido = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN>();
        if (p_es_recibido != null) {
                foreach (int item in p_es_recibido) {
                        MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN en = new MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN ();
                        en.Id = item;
                        mensajeEN.Es_recibido.Add (en);
                }
        }

        else{
                mensajeEN.Es_recibido = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN>();
        }

        //Call to MensajeCAD

        oid = _IMensajeCAD.CrearMensaje (mensajeEN);
        return oid;
}

public void ModificarMensaje (int p_Mensaje_OID, string p_asunto, string p_texto, string p_adjunto, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum p_tipo)
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
}
}
