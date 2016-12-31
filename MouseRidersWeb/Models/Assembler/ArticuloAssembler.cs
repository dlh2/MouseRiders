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

        public ArticuloDTO Convert(ArticuloEN art)
            {
                ArticuloDTO artDTO = null;
                if (art != null)
                {
                    artDTO = new ArticuloDTO();
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