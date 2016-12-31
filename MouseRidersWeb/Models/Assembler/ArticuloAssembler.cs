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
    public class ArticuloAssembler
    {
       
            public ControladorNotificacionesDTO Convert(ArticuloEN art)
            {
                ControladorNotificacionesDTO artDTO = null;
                if (art != null)
                {
                    artDTO = new ControladorNotificacionesDTO();
                    artDTO.Id = art.Id;
                    artDTO.Titulo = art.Titulo;
                    artDTO.Autor = art.Autor;
                    artDTO.Contenido = art.Contenido;
                    artDTO.ContenidoDescargable = art.ContenidoDescargable;
                    artDTO.Puntuacion = art.Puntuacion;
                    artDTO.Fecha = art.Fecha;
                    artDTO.Contador = art.Contador;
                    artDTO.Subtitulo = art.Subtitulo;
                    artDTO.Portada = art.Portada;
                    artDTO.Descripcion = art.Descripcion;
                }
                return artDTO;
            }       
    }
}