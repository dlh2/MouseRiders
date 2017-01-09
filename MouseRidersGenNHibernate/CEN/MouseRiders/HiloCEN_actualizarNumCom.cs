
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Hilo_actualizarNumCom) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class HiloCEN
{
public int ActualizarNumCom (int p_oid, int sumar_o_restar)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Hilo_actualizarNumCom) ENABLED START*/

        // Write here your custom code...

        HiloEN hiloEN = null;
        IHiloCAD _IHiloCAD = new HiloCAD ();
        HiloCEN hiloCEN = new HiloCEN (_IHiloCAD);

        if (sumar_o_restar != 1 || sumar_o_restar != -1) {
                return 0; //en el caso de que sea cero que no haga nada y pon las barras del or que no me van a mi
        }
        hiloEN = _IHiloCAD.ReadOID (p_oid);
        int aux = hiloEN.NumComentarios += sumar_o_restar;

        hiloCEN.ModificarHilo (p_oid, hiloEN.Creador, hiloEN.Fecha, aux, hiloEN.Titulo, hiloEN.PrimerComentario);

        return(hiloEN.NumComentarios);

        /*PROTECTED REGION END*/
}
}
}
