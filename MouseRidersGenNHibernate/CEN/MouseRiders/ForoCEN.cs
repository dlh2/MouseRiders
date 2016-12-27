

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
 *      Definition of the class ForoCEN
 *
 */
public partial class ForoCEN
{
private IForoCAD _IForoCAD;

public ForoCEN()
{
        this._IForoCAD = new ForoCAD ();
}

public ForoCEN(IForoCAD _IForoCAD)
{
        this._IForoCAD = _IForoCAD;
}

public IForoCAD get_IForoCAD ()
{
        return this._IForoCAD;
}

public int CrearForo ()
{
        ForoEN foroEN = null;
        int oid;

        //Initialized ForoEN
        foroEN = new ForoEN ();
        //Call to ForoCAD

        oid = _IForoCAD.CrearForo (foroEN);
        return oid;
}

public void ModificarForo (int p_Foro_OID)
{
        ForoEN foroEN = null;

        //Initialized ForoEN
        foroEN = new ForoEN ();
        foroEN.Id = p_Foro_OID;
        //Call to ForoCAD

        _IForoCAD.ModificarForo (foroEN);
}

public void BorrarForo (int id
                        )
{
        _IForoCAD.BorrarForo (id);
}
}
}
