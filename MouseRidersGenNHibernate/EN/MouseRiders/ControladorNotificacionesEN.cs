
using System;
// Definición clase ControladorNotificacionesEN
namespace MRModel.EN
{
public partial class ControladorNotificacionesEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo enviaN
 */
private System.Collections.Generic.IList<MRModel.EN.MensajeEN> enviaN;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<MRModel.EN.MensajeEN> EnviaN {
        get { return enviaN; } set { enviaN = value;  }
}





public ControladorNotificacionesEN()
{
        enviaN = new System.Collections.Generic.List<MRModel.EN.MensajeEN>();
}



public ControladorNotificacionesEN(int id, System.Collections.Generic.IList<MRModel.EN.MensajeEN> enviaN
                                   )
{
        this.init (Id, enviaN);
}


public ControladorNotificacionesEN(ControladorNotificacionesEN controladorNotificaciones)
{
        this.init (Id, controladorNotificaciones.EnviaN);
}

private void init (int id
                   , System.Collections.Generic.IList<MRModel.EN.MensajeEN> enviaN)
{
        this.Id = id;


        this.EnviaN = enviaN;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ControladorNotificacionesEN t = obj as ControladorNotificacionesEN;
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
