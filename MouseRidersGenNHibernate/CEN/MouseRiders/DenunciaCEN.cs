

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
 *      Definition of the class DenunciaCEN
 *
 */
public partial class DenunciaCEN
{
private IDenunciaCAD _IDenunciaCAD;

public DenunciaCEN()
{
        this._IDenunciaCAD = new DenunciaCAD ();
}

public DenunciaCEN(IDenunciaCAD _IDenunciaCAD)
{
        this._IDenunciaCAD = _IDenunciaCAD;
}

public IDenunciaCAD get_IDenunciaCAD ()
{
        return this._IDenunciaCAD;
}

public int CrearDenuncia (string p_motivo, int p_es_creada, Nullable<DateTime> p_fecha, int p_es_recibida)
{
        DenunciaEN denunciaEN = null;
        int oid;

        //Initialized DenunciaEN
        denunciaEN = new DenunciaEN ();
        denunciaEN.Motivo = p_motivo;


        if (p_es_creada != -1) {
                // El argumento p_es_creada -> Property es_creada es oid = false
                // Lista de oids id
                denunciaEN.Es_creada = new MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN ();
                denunciaEN.Es_creada.Id = p_es_creada;
        }

        denunciaEN.Fecha = p_fecha;


        if (p_es_recibida != -1) {
                // El argumento p_es_recibida -> Property es_recibida es oid = false
                // Lista de oids id
                denunciaEN.Es_recibida = new MouseRidersGenNHibernate.EN.MouseRiders.UsuarioEN ();
                denunciaEN.Es_recibida.Id = p_es_recibida;
        }

        //Call to DenunciaCAD

        oid = _IDenunciaCAD.CrearDenuncia (denunciaEN);
        return oid;
}

public void ModificarDenuncia (int p_Denuncia_OID, string p_motivo, Nullable<DateTime> p_fecha)
{
        DenunciaEN denunciaEN = null;

        //Initialized DenunciaEN
        denunciaEN = new DenunciaEN ();
        denunciaEN.Id = p_Denuncia_OID;
        denunciaEN.Motivo = p_motivo;
        denunciaEN.Fecha = p_fecha;
        //Call to DenunciaCAD

        _IDenunciaCAD.ModificarDenuncia (denunciaEN);
}

public void BorrarDenuncia (int id
                            )
{
        _IDenunciaCAD.BorrarDenuncia (id);
}

public DenunciaEN ReadOID (int id
                           )
{
        DenunciaEN denunciaEN = null;

        denunciaEN = _IDenunciaCAD.ReadOID (id);
        return denunciaEN;
}

public System.Collections.Generic.IList<DenunciaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DenunciaEN> list = null;

        list = _IDenunciaCAD.ReadAll (first, size);
        return list;
}
}
}
