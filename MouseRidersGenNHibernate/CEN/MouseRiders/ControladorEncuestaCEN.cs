

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
 *      Definition of the class ControladorEncuestaCEN
 *
 */
public partial class ControladorEncuestaCEN
{
private IControladorEncuestaCAD _IControladorEncuestaCAD;

public ControladorEncuestaCEN()
{
        this._IControladorEncuestaCAD = new ControladorEncuestaCAD ();
}

public ControladorEncuestaCEN(IControladorEncuestaCAD _IControladorEncuestaCAD)
{
        this._IControladorEncuestaCAD = _IControladorEncuestaCAD;
}

public IControladorEncuestaCAD get_IControladorEncuestaCAD ()
{
        return this._IControladorEncuestaCAD;
}

public int CrearCEncuesta ()
{
        ControladorEncuestaEN controladorEncuestaEN = null;
        int oid;

        //Initialized ControladorEncuestaEN
        controladorEncuestaEN = new ControladorEncuestaEN ();
        //Call to ControladorEncuestaCAD

        oid = _IControladorEncuestaCAD.CrearCEncuesta (controladorEncuestaEN);
        return oid;
}

public void ModificarCEncuesta (int p_ControladorEncuesta_OID)
{
        ControladorEncuestaEN controladorEncuestaEN = null;

        //Initialized ControladorEncuestaEN
        controladorEncuestaEN = new ControladorEncuestaEN ();
        controladorEncuestaEN.Id = p_ControladorEncuesta_OID;
        //Call to ControladorEncuestaCAD

        _IControladorEncuestaCAD.ModificarCEncuesta (controladorEncuestaEN);
}

public void BorrarCEncuesta (int id
                             )
{
        _IControladorEncuestaCAD.BorrarCEncuesta (id);
}
}
}
