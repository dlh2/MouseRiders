using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseRidersWeb.Assembler
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
