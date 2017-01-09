
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;



/*PROTECTED REGION ID(usingMouseRidersGenNHibernate.CP.MouseRiders_Admin_foro_administrarHilos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MouseRidersGenNHibernate.CP.MouseRiders
{
public partial class Admin_foroCP : BasicCP
{
public bool AdministrarHilos (int p_oid, string creador, int numComentarios, int tipo, int tipo2, int id_foro, int valoracion, string contenido, int com_oid, int tipo3, int id_rel)
{
        /*PROTECTED REGION ID(MouseRidersGenNHibernate.CP.MouseRiders_Admin_foro_administrarHilos) ENABLED START*/

        // Write here your custom code...

        /*permite crear, borrar, editar, modificar o desvincular hilos del foro
         * tipo=1 hilo, tipo=2 comentario
         * tipo2=1 crear, tipo2=2 borrar, tipo2=2 modificar
         */
        IHiloCAD _IHiloCAD = null;
        IComentarioCAD _IComentarioCAD = null;
        try
        {
                _IHiloCAD = new HiloCAD (session);
                HiloCEN HiloCen = new HiloCEN (_IHiloCAD);
                _IComentarioCAD = new ComentarioCAD (session);
                ComentarioCEN ComentarioCen = new ComentarioCEN (_IComentarioCAD);
                if (creador == null) {
                        creador = "anonimo";
                }
                DateTime fecha = DateTime.Now;
                if (numComentarios < 0) {
                        numComentarios = 0;
                }
                if (tipo < 1 || tipo > 2) {
                        return false;
                }
                if (tipo2 < 1 || tipo2 > 3) {
                        return false;
                }
                switch (tipo) {
                case 1:
                        if (fecha == null) {
                                return false;
                        }
                        switch (tipo2) {
                        case 1:
                                HiloCen.CrearHilo (creador, fecha, numComentarios, "desconocido");
                                return true;

                        case 2:
                                if (p_oid == -1) {
                                        return false;
                                }
                                if (HiloCen == null) {
                                        return false;
                                }
                                HiloCen.ModificarHilo (p_oid, creador, fecha, numComentarios, "desconocido");
                                return true;

                        case 3:
                                if (p_oid == -1) {
                                        return false;
                                }
                                HiloCen.BorrarHilo (p_oid);
                                return true;
                        }
                        break;

                case 2:
                        if (valoracion < 0) {
                                valoracion = 0;
                        }
                        switch (tipo2) {
                        case 1:
                                int oid = ComentarioCen.CrearComentario (creador, fecha, contenido, valoracion);
                                if (tipo3 == 1) {
                                        ComentarioCen.RelacionaArticulo (oid, id_rel);
                                }
                                else if (tipo3 == 2) {
                                        ComentarioCen.RelacionaHilo (oid, id_rel);
                                }
                                return true;

                        case 2:
                                if (com_oid == 0) {
                                        return false;
                                }
                                if (ComentarioCen == null) {
                                        return false;
                                }
                                ComentarioCen.ModificarComentario (com_oid, creador, fecha, contenido, valoracion);
                                return true;

                        case 3:
                                if (com_oid == 0) {
                                        return false;
                                }
                                ComentarioCen.BorrarComentario (com_oid);
                                return true;
                        }
                        break;
                }
                return false;
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
