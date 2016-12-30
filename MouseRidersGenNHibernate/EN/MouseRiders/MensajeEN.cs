
using System;
// Definición clase MensajeEN
namespace MRModel.EN
{
public partial class MensajeEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo asunto
 */
private string asunto;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo adjunto
 */
private string adjunto;



/**
 *	Atributo tipo
 */
private MRModel.Enumerated.T_MensajeEnum tipo;



/**
 *	Atributo es_enviado
 */
private MRModel.EN.UsuarioEN es_enviado;



/**
 *	Atributo es_recibido
 */
private System.Collections.Generic.IList<MRModel.EN.UsuarioEN> es_recibido;



/**
 *	Atributo es_enviadoN
 */
private MRModel.EN.ControladorNotificacionesEN es_enviadoN;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Asunto {
        get { return asunto; } set { asunto = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual string Adjunto {
        get { return adjunto; } set { adjunto = value;  }
}



public virtual MRModel.Enumerated.T_MensajeEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual MRModel.EN.UsuarioEN Es_enviado {
        get { return es_enviado; } set { es_enviado = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.UsuarioEN> Es_recibido {
        get { return es_recibido; } set { es_recibido = value;  }
}



public virtual MRModel.EN.ControladorNotificacionesEN Es_enviadoN {
        get { return es_enviadoN; } set { es_enviadoN = value;  }
}





public MensajeEN()
{
        es_recibido = new System.Collections.Generic.List<MRModel.EN.UsuarioEN>();
}



public MensajeEN(int id, string asunto, string texto, string adjunto, MRModel.Enumerated.T_MensajeEnum tipo, MRModel.EN.UsuarioEN es_enviado, System.Collections.Generic.IList<MRModel.EN.UsuarioEN> es_recibido, MRModel.EN.ControladorNotificacionesEN es_enviadoN
                 )
{
        this.init (Id, asunto, texto, adjunto, tipo, es_enviado, es_recibido, es_enviadoN);
}


public MensajeEN(MensajeEN mensaje)
{
        this.init (Id, mensaje.Asunto, mensaje.Texto, mensaje.Adjunto, mensaje.Tipo, mensaje.Es_enviado, mensaje.Es_recibido, mensaje.Es_enviadoN);
}

private void init (int id
                   , string asunto, string texto, string adjunto, MRModel.Enumerated.T_MensajeEnum tipo, MRModel.EN.UsuarioEN es_enviado, System.Collections.Generic.IList<MRModel.EN.UsuarioEN> es_recibido, MRModel.EN.ControladorNotificacionesEN es_enviadoN)
{
        this.Id = id;


        this.Asunto = asunto;

        this.Texto = texto;

        this.Adjunto = adjunto;

        this.Tipo = tipo;

        this.Es_enviado = es_enviado;

        this.Es_recibido = es_recibido;

        this.Es_enviadoN = es_enviadoN;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MensajeEN t = obj as MensajeEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
