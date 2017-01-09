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
    public class MensajeAssembler
    {
        public MensajeDTO Convert(MensajeEN men)
        {
            MensajeDTO menDTO = null;
            if (men != null)
            {
                menDTO = new MensajeDTO();
                menDTO.Id = men.Id;
                menDTO.Asunto = men.Asunto;
                menDTO.Texto = men.Texto;
                menDTO.Tipo = men.Tipo;
                menDTO.Adjunto = men.Adjunto;
                for (int i = 0; i < men.Es_recibido.Count; i++)
                {
                    menDTO.Destinatario += men.Es_recibido[i].Email;
                    if (i != men.Es_recibido.Count-1)
                    {
                        menDTO.Destinatario += ", ";
                    }
                }
            }
            return menDTO;
        }
        public MensajeDTO ConvertConUsuRecibido(MensajeEN us)
        {
            MensajeDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.U_Recibido = null;
                }
                IList<UsuarioEN> Recibe = us.Es_recibido;
                if (Recibe != null)
                {
                    usDTO.U_Recibido = new List<UsuarioDTO>();
                    foreach (UsuarioEN entry in Recibe)
                        usDTO.U_Recibido.Add(new UsuarioAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        public MensajeDTO ConvertConNotificacionesRecibidas(MensajeEN c)
        {
            MensajeDTO cDTO = null;
            if (c != null)
            {
                cDTO = this.Convert(c);
                if (cDTO != null)
                {
                    cDTO.Notificaciones = null;
                }
                ControladorNotificacionesEN Recibe = c.Es_enviadoN;
                if (Recibe != null)
                {
                    cDTO.Notificaciones = new ControladorNotificacionesAssembler().Convert(Recibe);
                }
            }
            return cDTO;
        }
    }
}
