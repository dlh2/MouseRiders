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
    public class HiloAssembler
    {
        public HiloDTO Convert(HiloEN hil)
        {
            HiloDTO hilDTO = null;
            if (hil != null)
            {
                hilDTO = new HiloDTO();
                hilDTO.Id = hil.Id;
                hilDTO.Creador = hil.Creador;
                hilDTO.Fecha = hil.Fecha;
                hilDTO.NumComentarios = hil.NumComentarios;
                hilDTO.Titulo = hil.Titulo;
            }
            return hilDTO;
        }
        public HiloDTO ConvertConComentario_Hilo(HiloDTO us)
        {
            HiloDTO usDTO = this.Convert(us);
            if (us != null)
            {
                usDTO.Comentario = null;
                IList<ComentarioEN> Recibe = us.Comentario;
                if (Recibe != null)
                {
                    usDTO.Comentario = new List<ComentarioDTO>();
                    foreach (ComentarioEN entry in Recibe)
                        usDTO.Comentario.Add(new ComentarioAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        
    }
}