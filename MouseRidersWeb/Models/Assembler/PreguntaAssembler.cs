using MRModel.CAD;
using MRModel.CEN;
using MRModel.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRWeb.Assembler
{
    public class PreguntaAssembler
    {
        public PreguntaDTO Convert(PreguntaEN preg)
        {
            PreguntaDTO pregDTO = null;
            if (preg != null)
            {
                pregDTO = new PreguntaDTO();
                pregDTO.id = preg.Id;
                pregDTO.Pregunta = preg.Pregunta;
            }
            return pregDTO;
        }

        public PreguntaDTO ConvertConRespuesta(PreguntaEN preg)
        {
            PreguntaDTO pregDTO = null;
            if (preg != null)
            {
                pregDTO = this.Convert(preg);
            }
            
            if (pregDTO != null)
            {
                pregDTO.Tiene = null;
                IList<RespuestaEN> Tiene = preg.Tiene;
                if (Tiene != null)
                {
                    pregDTO.Tiene = new List<RespuestaEN>();
                    foreach (RespuestaEN entry in Tiene)
                        pregDTO.Tiene.Add(entry);
                }
            }
            return pregDTO;
        }
    }
}
