using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;
using MouseRidersGenNHibernate.EN.MouseRiders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseRidersGenNHibernate.Assembler.MouseRiders
{
    public class EncuestaAssembler
    {
      public EncuestaDTO ConvertENToModelUI (EncuestaEN enc){
        EncuestaDTO encDTO = new EncuestaDTO();
        
        if( enc !=null ){
            encDTO = new EncuestaDTO();
                    
            encDTO.id=enc.Id;
            encDTO.titulo=enc.Titulo;
            
            encDTO.Tiene=null;
            IList<PreguntaEN> Tiene=enc.Tiene;
            if(Tiene!=null){
                encDTO.Tiene= new List<PreguntaDTO>();
                foreach (PreguntaEN entry in Tiene)
                    encDTO.Tiene.Add(new PreguntaAssembler().Convert(entry));
            }}        
            return encDTO;
        }      
    }

    public class PreguntaAssembler
        {
        public PreguntaDTO Convert (PreguntaEN preg){
            PreguntaDTO pregDTO = new PreguntaDTO();
            if (preg != null)
            {
                pregDTO = new PreguntaDTO();

                pregDTO.id = preg.Id;
                pregDTO.Pregunta=preg.Pregunta;
                pregDTO.Tiene=null;
                IList<RespuestaEN> Tiene=preg.Tiene;
                if(Tiene!=null){
                    pregDTO.Tiene= new List<RespuestaEN>();
                    foreach (RespuestaEN entry in Tiene)
                        pregDTO.Tiene.Add(entry);
                }
            }
            return pregDTO;
         }
    }
}
