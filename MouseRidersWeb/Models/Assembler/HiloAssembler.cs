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
                UsuarioCEN usuCEN=new UsuarioCEN();
                hilDTO.ID_Creador = usuCEN.ReadFilterPorEmail(hil.Creador).Id;
                
            }
            return hilDTO;
        }
        public HiloDTO ConvertConComentario_Hilo(HiloEN us)
        {
            HiloDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Comentario = null;
                }
                IList<ComentarioEN> Recibe = us.Contiene;
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