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
    public class ControladorNotificacionesAssembler
    {
        public ControladorNotificacionesDTO Convert(ControladorNotificacionesEN cns)
        {
            ControladorNotificacionesDTO cnsDTO = null;
            if (cns != null)
            {
                cnsDTO = new ControladorNotificacionesDTO();
                cnsDTO.Id = cns.Id;
            }
            return cnsDTO;
        }

        public ControladorNotificacionesDTO ConvertConNotificacionesRecibidas(ControladorNotificacionesEN c)
        {
            ControladorNotificacionesDTO cDTO = null;
            if (c != null)
            {
                cDTO = this.Convert(c);
                if (cDTO != null)
                {
                    cDTO.enviaN = null;
                }
                IList<MensajeEN> Recibe = c.EnviaN;
                if (Recibe != null)
                {
                    cDTO.enviaN = new List<MensajeDTO>();
                    foreach (MensajeEN entry in Recibe)
                        cDTO.enviaN.Add(new MensajeAssembler().Convert(entry));
                }
            }
            return cDTO;
        }
    }
}