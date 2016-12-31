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
    public class BloqueoAssembler
    {
        public BloqueoDTO Convert(BloqueoEN blo)
        {
            BloqueoDTO bloDTO = null;
            if (blo != null)
            {
                bloDTO = new BloqueoDTO();
                bloDTO.Id = blo.Id;
		        bloDTO.FechaInicio=blo.FechaInicio;
                bloDTO.FechaFin = blo.FechaFin;
            }
            return bloDTO;
        }
        public BloqueoDTO ConvertConDenuncia(BloqueoEN us)
        {
            BloqueoDTO usDTO = this.Convert(us);
            if (us != null)
            {
                usDTO.Contiene = null;
                IList<DenunciaEN> Recibe = us.Contiene;
                if (Recibe != null)
                {
                    usDTO.Contiene = new List<DenunciaDTO>();
                    foreach (DenunciaEN entry in Recibe)
                        usDTO.Contiene.Add(new DenunciaAssembler().Convert(entry));
                }
            }
            return usDTO;
        }

     }
}

