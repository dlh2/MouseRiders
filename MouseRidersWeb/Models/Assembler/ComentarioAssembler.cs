using MRModel.CAD;
using MRModel.CEN;
using MRWeb.DTO;
using MRModel.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRWeb.Assembler
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
