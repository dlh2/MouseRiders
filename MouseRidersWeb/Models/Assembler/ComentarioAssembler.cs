using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.DTO.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseRidersGenNHibernate.Assembler.MouseRiders
{
    public class ComentarioAssembler
    {
        public ComentarioDTO Convert(ComentarioEN com)
        {
            ComentarioDTO comDTO = null;
            if (com != null)
            {
                comDTO = new ComentarioDTO();
                comDTO.Id = com.Id;
                comDTO.Creador = com.Creador;
                comDTO.Fecha = com.Fecha;
                comDTO.Contenido = com.Contenido;
                comDTO.Valoracion = com.Valoracion;
            }
            return comDTO;
        }

    }
}
