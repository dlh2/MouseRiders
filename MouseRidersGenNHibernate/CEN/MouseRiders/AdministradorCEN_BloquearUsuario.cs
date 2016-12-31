
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


/*PROTECTED REGION ID(usingMRModel.CEN_Administrador_bloquearUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MRModel.CEN
{
public partial class AdministradorCEN
{
public bool BloquearUsuario (string p_oid)
{
        /*PROTECTED REGION ID(MRModel.CEN_Administrador_bloquearUsuario) ENABLED START*/

        // Write here your custom code...

        /*
         *
         * busca y lee las denuncias de un usuario y crea un bloqueo a ese usuario si tiene mas de tres denuncias
         *
         *
         *
         */



        int Ndenuncias = 0;

        bool bloqueado = false;
        UsuarioEN _usuarioEN = (UsuarioEN)_IAdministradorCAD.ReadOIDDefault (Int32.Parse(p_oid));

        Ndenuncias = _usuarioEN.CreaD != null ? _usuarioEN.CreaD.Count : 0;

        BloqueoEN _bloqueo = null;

        _bloqueo = new BloqueoEN ();

        if (Ndenuncias >= 3) {
                _usuarioEN.Es_de = _bloqueo; //al ser una clave ajena (0,1) se le asigna directamente el bloqueo creado a la relacion que en este caso

                //actua como un atributo en lugar de como una lista

                IUsuarioCAD _IUsuarioCAD = (IUsuarioCAD)_IAdministradorCAD;

                _IUsuarioCAD.ModificarUsuario (_usuarioEN);

                UsuarioCEN usuarioCEN = new UsuarioCEN (_IUsuarioCAD);

                usuarioCEN.RelacionaBloqueo (Int32.Parse(_usuarioEN.Email), _usuarioEN.Es_de.Id);

                bloqueado = true;
        }

        return(bloqueado);

        /*PROTECTED REGION END*/
}
}
}
