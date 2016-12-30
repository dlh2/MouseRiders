
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


/*PROTECTED REGION ID(usingMRModel.CEN_Comentario_actualizarPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MRModel.CEN
{
public partial class ComentarioCEN
{
public bool ActualizarPuntuacion (int id_comentario, int puntuacion)
{
        /*PROTECTED REGION ID(MRModel.CEN_Comentario_actualizarPuntuacion) ENABLED START*/

        // Write here your custom code...

        //actualizarPuntuacion: suma o resta un punto a la valoracion del comentario

        //inicializacion basica
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioCAD.ReadOIDDefault (id_comentario);

        if (comentarioEN == null || (puntuacion < -5 && puntuacion > 5))
                return false;

        //comentarioEN.Valoracion = comentarioEN.Valoracion + puntuacion;
        comentarioEN.Valoracion = puntuacion;
        _IComentarioCAD.ModificarComentario (comentarioEN);

        return true;

        /*PROTECTED REGION END*/
}
}
}
