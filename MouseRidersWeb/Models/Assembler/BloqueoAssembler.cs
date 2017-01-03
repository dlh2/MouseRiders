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
            BloqueoDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if(usDTO !=null)
                {
                usDTO.Contiene = null;
                }
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

