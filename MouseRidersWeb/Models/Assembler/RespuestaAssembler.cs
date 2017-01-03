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
    public class RespuestaAssembler
    {
        public RespuestaDTO Convert(RespuestaEN resp)
        {
            RespuestaDTO respDTO = null;
            if (resp != null)
            {
                respDTO = new RespuestaDTO();
                respDTO.Id = resp.Id;
                respDTO.Respuesta = respDTO.Respuesta;
                respDTO.Tipo = resp.Tipo;
                respDTO.Contador = resp.Contador;
                respDTO.Frecuencia = resp.Frecuencia;
            }
            return respDTO;
        }
        
    }
}