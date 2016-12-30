
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MRModel.Exceptions;
using MRModel.EN;
using MRModel.CAD;


/*PROTECTED REGION ID(usingMRModel.CEN_Usuario_autenticar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MRModel.CEN
{
public partial class UsuarioCEN
{
public bool Autenticar (int p_id, string p_email, string p_pass)
{
        /*PROTECTED REGION ID(MRModel.CEN_Usuario_autenticar) ENABLED START*/

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
