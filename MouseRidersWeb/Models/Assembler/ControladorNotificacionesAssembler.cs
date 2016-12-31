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
            ControladorNotificacionesDTO cDTO = this.Convert(c);
            if (c != null)
            {
                cDTO.enviaN = null;
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