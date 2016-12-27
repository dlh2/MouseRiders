
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


/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CEN.MouseRiders_Usuario_denunciarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CEN.MouseRiders
{
public partial class UsuarioCEN
{
public bool DenunciarUsuario (int p_oid, int u_denunciado, string motivo)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CEN.MouseRiders_Usuario_denunciarUsuario) ENABLED START*/

        // Write here your custom code...

        //denunciarUsuario: crea una denuncia, pasandole los datos necesarios, y la guarda en la base de datos. Si lo hace devuelve true

        //declaraciones basicas
        if (p_oid == null || u_denunciado == null || motivo == null) {
                return false;
        }

        int aux = -1;


        IDenunciaCAD _IDenunciaCAD = new DenunciaCAD ();
        DenunciaCEN denunciaCEN = new DenunciaCEN (_IDenunciaCAD);

        aux = denunciaCEN.CrearDenuncia (motivo, p_oid, DateTime.Now, u_denunciado);

        if (aux == -1) {
                return false;
        }

        return true;

        /*PROTECTED REGION END*/
}
}
}
