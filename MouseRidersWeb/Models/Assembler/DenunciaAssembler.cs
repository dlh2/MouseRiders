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
        public DenunciaDTO ConvertConUsuAcusado(DenunciaEN us)
        {
            DenunciaDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.U_Acusado = null;
                }
                UsuarioEN Recibe = us.Es_recibida;
                if (Recibe != null)
                {
                    usDTO.U_Acusado = new UsuarioAssembler().Convert(Recibe);
                }
            }
            return usDTO;
        }
        public DenunciaDTO ConvertConUsuDenunciante(DenunciaEN us)
        {
            DenunciaDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.U_Denunciante = null;
                }
                UsuarioEN Recibe = us.Es_creada;
                if (Recibe != null)
                {
                    usDTO.U_Denunciante = new UsuarioAssembler().Convert(Recibe);
                }
            }
            return usDTO;
        }
        
    }
}