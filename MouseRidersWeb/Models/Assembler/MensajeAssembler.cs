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
    public class MensajeAssembler
    {
        public MensajeDTO Converto(MensajeEN men)
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
            }
            return menDTO;
        }

    }
}
