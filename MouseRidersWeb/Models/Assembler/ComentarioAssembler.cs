using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersWeb.DTO;
using MouseRidersGenNHibernate.EN.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseRidersWeb.Assembler
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
                UsuarioCEN usuCEN = new UsuarioCEN();
                comDTO.ID_Creador = usuCEN.ReadFilterPorEmail(com.Creador).Id;
            }
            return comDTO;
        }

    }
}
