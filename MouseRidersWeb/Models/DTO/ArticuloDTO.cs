using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Definición clase ArticuloDTO
namespace MouseRidersWeb.DTO
{
    public class ArticuloDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }




        /**
         *	Atributo Titulo
         */
        [Display(Prompt = "Titulo", Description = "Titulo del articulo", Name = "Titulo:")]
        [Required(ErrorMessage = "Debe tener un titulo")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "El Titulo no puede tener más de {0} caracteres")]
        public string Titulo { get; set; }
        

        /**
        *	Atributo fecha
        */
        [Display(Prompt = "Fecha", Description = "Fecha del comentario", Name = "Fecha:")]
        [Required(ErrorMessage = "Debe de indicar una fecha para el comentario")]
        public Nullable<DateTime> Fecha { get; set; }


        /**
         *	Atributo Autor
         */
        [Display(Prompt = "Autor", Description = "Autor del Articulo", Name = "Autor:")]
        [Required(ErrorMessage = "Debe tener un autor")]
        [StringLength(maximumLength: Globals.USUARIO_MAX_LENGTH, ErrorMessage = "El nombre del Autor no puede tener más de {0} caracteres")]
        public string Autor { get; set; }


        //Atributo Puntuacion
        [Display(Prompt = "Puntuacion", Description = "Puntuacion del articulo", Name = "Puntuacion:")]
        [Required(ErrorMessage = "Debe existir un puntuacion")]
        [StringLength(maximumLength: Globals.PUNTUACION_MAX_LENGTH, ErrorMessage = "El puntuacion del Articulo no puede tener más de {0} caracteres")]
        [Range(Globals.PUNTUACION_MIN, Globals.PUNTUACION_MAX,
           ErrorMessage = "{0} debe estar entre {1} y {2}")]
        public float Puntuacion { get; set; }

        /**
         *	Atributo Contenido
         */
        [Display(Prompt = "Contenido", Description = "Contenido del Articulo", Name = "Contenido:")]
        [Required(ErrorMessage = "Debe tener un contenido")]
        [StringLength(maximumLength: Globals.DESCRIPCION_MAX_LENGTH, ErrorMessage = "El contenido no puede tener más de {0} caracteres")]
        public string Contenido { get; set; }

        /**
         *	Atributo Contenido descargable
         */
        [Display(Prompt = "Contenido descargable", Description = "Contenido descargable del articulo", Name = "Contenido descargable:")]
        [Required(ErrorMessage = "Debe tener un contenido descargable")]
        [StringLength(maximumLength: Globals.DESCRIPCION_MAX_LENGTH, ErrorMessage = "El contenido descargable no puede tener más de {0} caracteres")]
        public string ContenidoDescargable { get; set; }

        /**
        *	Atributo contador
        */
        [Display(Prompt = "Contador", Description = "Contador de comentarios del articulo", Name = "Contador:")]
        //[StringLength(maximumLength: Globals.CONTENIDO_MAX_LENGTH, ErrorMessage = "El contenido descargable no puede tener más de {0} caracteres")]
        public int Contador { get; set; }


        /**
         *	Atributo Subtitulo
         */
        [Display(Prompt = "Subtitulo", Description = "Subtitulo del articulo", Name = "Subtitulo:")]
        [Required(ErrorMessage = "Debe tener un Subtitulo")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "El Subtitulo no puede tener más de {0} caracteres")]
        public string Subtitulo { get; set; }


        /**
        *	Atributo Portada
        */
        [Display(Prompt = "Portada", Description = "Portada del Articulo", Name = "Portada:")]
        [Required(ErrorMessage = "Debe tener una Portada")]
        [StringLength(maximumLength: Globals.DESCRIPCION_MAX_LENGTH, ErrorMessage = "La Portada no puede tener más de {0} caracteres")]
        public string Portada { get; set; }

        /**
        *	Atributo Descripcion
        */
        [Display(Prompt = "Descripcion", Description = "Descripcion del Articulo", Name = "Descripcion:")]
        [Required(ErrorMessage = "Debe tener una Descripcion")]
        [StringLength(maximumLength: Globals.DESCRIPCION_MAX_LENGTH, ErrorMessage = "La Descripcion no puede tener más de {0} caracteres")]
        public string Descripcion { get; set; }


        //Atributo Comentario
        [ScaffoldColumn(false)]
        [Display(Prompt = "Comentarios", Description = "Comentarios", Name = "Comentarios")]
        public IList<ComentarioDTO> Comentario { get; set; }

    }
}