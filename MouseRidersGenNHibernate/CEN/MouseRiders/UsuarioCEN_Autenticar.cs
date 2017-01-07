
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


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Usuario_autenticar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class UsuarioCEN
{
public int Autenticar (string p_email_o_nickname, string p_pass)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Usuario_autenticar) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuarioEn = null;

        if (p_email_o_nickname == null || p_pass == null) {
                return -1;
        }

        usuarioEn = _IUsuarioCAD.ReadFilterAuth (p_email_o_nickname);
        if (usuarioEn == null)
        {
            return -1;
        }
        if ((usuarioEn.Nombreusuario != p_email_o_nickname && usuarioEn.Email != p_email_o_nickname) || usuarioEn.Contrasenya != p_pass) {
                return -1;
        }
        if (usuarioEn.Tiene == null)
        {
            return 1; //Usuario
        }
        else
        {
            return (int)usuarioEn.Tiene[0].PermisoOID.Rol;
        }

        /*PROTECTED REGION END*/
}
}
}
