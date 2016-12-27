
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
public bool Autenticar (int p_id, string p_email, string p_pass)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Usuario_autenticar) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuarioEn = null;

        if (p_email == null || p_pass == null) {
                return false;
        }

        usuarioEn = _IUsuarioCAD.ReadOIDDefault (p_id);

        if (usuarioEn == null || usuarioEn.Contrasenya != p_pass) {
                return false;
        }

        return true;

        /*PROTECTED REGION END*/
}
}
}
