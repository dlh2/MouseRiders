using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseRidersWeb.Assembler
{
    public class EncuestaAssembler
    {

        public EncuestaDTO Convert(EncuestaEN enc)
        {
            EncuestaDTO encDTO = null;
            if (enc != null)
            {
                encDTO = new EncuestaDTO();
                encDTO.id = enc.Id;
                encDTO.titulo = enc.Titulo;
            }
            return encDTO;
        }
        public EncuestaDTO ConvertConPreguntaYRespuesta(EncuestaEN enc)
        {
            EncuestaDTO encDTO = null;
            if (enc != null)
            {
                encDTO = this.Convert(enc);
            }
            if (encDTO != null)
            {
                encDTO.Tiene = null;
                IList<PreguntaEN> Tiene = enc.Tiene;
                if (Tiene != null)
                {
                    encDTO.Tiene = new List<PreguntaDTO>();
                    foreach (PreguntaEN entry in Tiene)
                        encDTO.Tiene.Add(new PreguntaAssembler().ConvertConRespuesta(entry));
                }
            }
            return encDTO;
        }
    }
}
