

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
 *      Definition of the class HiloCEN
 *
 */
public partial class HiloCEN
{
private IHiloCAD _IHiloCAD;

public HiloCEN()
{
        this._IHiloCAD = new HiloCAD ();
}

public HiloCEN(IHiloCAD _IHiloCAD)
{
        this._IHiloCAD = _IHiloCAD;
}

public IHiloCAD get_IHiloCAD ()
{
        return this._IHiloCAD;
}

public int CrearHilo (string p_creador, Nullable<DateTime> p_fecha, int p_numComentarios, System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.ComentarioEN> p_contiene, string p_titulo, string p_primerComentario)
{
        HiloEN hiloEN = null;
        int oid;

        //Initialized HiloEN
        hiloEN = new HiloEN ();
        hiloEN.Creador = p_creador;

        hiloEN.Fecha = p_fecha;

        hiloEN.NumComentarios = p_numComentarios;

        hiloEN.Contiene = p_contiene;

        hiloEN.Titulo = p_titulo;

        hiloEN.PrimerComentario = p_primerComentario;

        //Call to HiloCAD

        oid = _IHiloCAD.CrearHilo (hiloEN);
        return oid;
}

public void ModificarHilo (int p_Hilo_OID, string p_creador, Nullable<DateTime> p_fecha, int p_numComentarios, string p_titulo, string p_primerComentario)
{
        HiloEN hiloEN = null;

        //Initialized HiloEN
        hiloEN = new HiloEN ();
        hiloEN.Id = p_Hilo_OID;
        hiloEN.Creador = p_creador;
        hiloEN.Fecha = p_fecha;
        hiloEN.NumComentarios = p_numComentarios;
        hiloEN.Titulo = p_titulo;
        hiloEN.PrimerComentario = p_primerComentario;
        //Call to HiloCAD

        _IHiloCAD.ModificarHilo (hiloEN);
}

public void BorrarHilo (int id
                        )
{
        _IHiloCAD.BorrarHilo (id);
}

public HiloEN ReadOID (int id
                       )
{
        HiloEN hiloEN = null;

        hiloEN = _IHiloCAD.ReadOID (id);
        return hiloEN;
}

public System.Collections.Generic.IList<HiloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<HiloEN> list = null;

        list = _IHiloCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<MouseRidersGenNHibernate.EN.MouseRiders.HiloEN> ReadFilter (string p_nombre, Nullable<DateTime> p_fecha, bool ? p_mayor)
{
        return _IHiloCAD.ReadFilter (p_nombre, p_fecha, p_mayor);
}
}
}
