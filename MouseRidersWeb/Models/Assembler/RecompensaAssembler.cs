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
    public class RecompensaAssembler
    {
        public RecompensaDTO Convert(RecompensaEN rec)
        {
            RecompensaDTO recDTO = null;
            if (rec != null)
            {
                recDTO = new RecompensaDTO();
                recDTO.Id = rec.Id;
                recDTO.Nombre = rec.Nombre;
                recDTO.Descripcion = rec.Descripcion;
                recDTO.Puntuacion = rec.Puntuacion;
            }
            return recDTO;
        }
        public RecompensaDTO ConvertConComentario_Articulo(RecompensaEN us)
        {
            RecompensaDTO usDTO = this.Convert(us);
            if (us != null)
            {
                usDTO.Obtiene = null;
                IList<UsuarioEN> Recibe = us.Otorgada;
                if (Recibe != null)
                {
                    usDTO.Obtiene = new List<UsuarioDTO>();
                    foreach (UsuarioEN entry in Recibe)
                        usDTO.Obtiene.Add(new UsuarioAssembler().Convert(entry));
                }
            }
            return usDTO;
        }

    }
}