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