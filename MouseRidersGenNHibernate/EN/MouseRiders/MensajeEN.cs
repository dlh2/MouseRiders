
using System;
// Definición clase MensajeEN
namespace MouseRidersGenNHibernate.EN.MouseRiders
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
private MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum tipo;



/**
 *	Atributo es_enviado
 */
private MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_enviado;



/**
 *	Atributo es_recibido
 */
private System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> es_recibido;



/**
 *	Atributo es_enviadoN
 */
private MouseRidersGenNHibernate.EN.MouseRiders.ControladorNotificacionesEN es_enviadoN;






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



public virtual MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN Es_enviado {
        get { return es_enviado; } set { es_enviado = value;  }
}



public virtual System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> Es_recibido {
        get { return es_recibido; } set { es_recibido = value;  }
}



public virtual MouseRidersGenNHibernate.EN.MouseRiders.ControladorNotificacionesEN Es_enviadoN {
        get { return es_enviadoN; } set { es_enviadoN = value;  }
}





public MensajeEN()
{
        es_recibido = new System.Collections.Generic.List<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN>();
}



public MensajeEN(int id, string asunto, string texto, string adjunto, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum tipo, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_enviado, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> es_recibido, MouseRidersGenNHibernate.EN.MouseRiders.ControladorNotificacionesEN es_enviadoN
                 )
{
        this.init (Id, asunto, texto, adjunto, tipo, es_enviado, es_recibido, es_enviadoN);
}


public MensajeEN(MensajeEN mensaje)
{
        this.init (Id, mensaje.Asunto, mensaje.Texto, mensaje.Adjunto, mensaje.Tipo, mensaje.Es_enviado, mensaje.Es_recibido, mensaje.Es_enviadoN);
}

private void init (int id
                   , string asunto, string texto, string adjunto, MouseRidersGenNHibernate.Enumerated.MouseRiders.T_MensajeEnum tipo, MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN es_enviado, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN> es_recibido, MouseRidersGenNHibernate.EN.MouseRiders.ControladorNotificacionesEN es_enviadoN)
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
