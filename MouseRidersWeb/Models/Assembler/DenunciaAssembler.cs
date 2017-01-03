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
    public class DenunciaAssembler
    {
        public DenunciaDTO Convert(DenunciaEN den)
        {
            DenunciaDTO denDTO = null;
            if (den != null)
            {
                denDTO = new DenunciaDTO();
                denDTO.Id = den.Id;
                denDTO.Fecha = den.Fecha;
                denDTO.Motivo = den.Motivo;
            }
            return denDTO;
        }
        
    }
}