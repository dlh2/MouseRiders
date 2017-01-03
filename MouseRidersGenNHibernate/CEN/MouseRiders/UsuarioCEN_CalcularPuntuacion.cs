
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


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Usuario_calcularPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class UsuarioCEN
{
public int CalcularPuntuacion (int p_oid, int puntuacion)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Usuario_calcularPuntuacion) ENABLED START*/

        // Write here your custom code...

        /*se actualiza cada vez que el usuario comenta, valora o realiza una encuesta y le suma
         * puntos en  funcion de la accion realizada, valorar da 5 puntos, comentar 20 y encuestas 100*/
        UsuarioEN usuarioEN = null;

        if (puntuacion != 5 && puntuacion != 20 && puntuacion != 100) {
                return -1;
        }

        usuarioEN = _IUsuarioCAD.ReadOID (p_oid);
        if (usuarioEN == null) {
                return -1;
        }
        puntuacion += usuarioEN.Puntuacion;
        usuarioEN.Puntuacion = puntuacion;
        _IUsuarioCAD.ModificarUsuario (usuarioEN);
        return puntuacion;

        /*PROTECTED REGION END*/
}
}
}
