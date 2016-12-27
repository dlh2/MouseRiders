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
        //EncuestaDTO encDTO = null;
        EncuestaDTO encDTO = new EncuestaDTO();
        //EncuestaCAD encCAD = null;
        //EncuestaCEN encCEN = null;
        
        if( enc !=null ){
            encDTO = new EncuestaDTO();
            //encCAD = new EncuestaCAD(session);
            //encCEN = new EncuestaCEN(encCAD);
                    
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
           //PreguntaCAD pregCAD = null;
            //PreguntaCEN pregCEN = null;
            if (preg != null)
            {
                pregDTO = new PreguntaDTO();
                //pregCAD = new EncuestaCAD(session);
                //pregCEN = new EncuestaCEN(pregCAD);

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
