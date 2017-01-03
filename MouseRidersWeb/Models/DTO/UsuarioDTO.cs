using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Definición clase UsuarioDTO
namespace MouseRidersWeb.DTO
{
    public class UsuarioDTO
    {
        //Atributo Id
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        //Atributo Email
        [Display(Prompt = "Email", Description = "Email del usuario", Name = "Email:")]
        [Required(ErrorMessage = "Debe existir un email")]
        [StringLength(maximumLength: Globals.EMAIL_MAX_LENGTH, ErrorMessage = "El email del usuario no puede tener más de {0} caracteres")]
        public string Email { get; set; }

        //Atributo Nombre
        [Display(Prompt = "Nombre", Description = "Nombre del usuario", Name = "Nombre:")]
        [Required(ErrorMessage = "Debe existir un nombre")]
        [StringLength(maximumLength: Globals.NOMBRE_MAX_LENGTH, ErrorMessage = "El nombre del usuario no puede tener más de {0} caracteres")]
        public string Nombre { get; set; }

        //Atributo Apellidos
        [Display(Prompt = "Apellidos", Description = "Apellidos del usuario", Name = "Apellidos:")]
        [Required(ErrorMessage = "Debe existir un apellido")]
        [StringLength(maximumLength: Globals.APELLIDOS_MAX_LENGTH, ErrorMessage = "El apellido del usuario no puede tener más de {0} caracteres")]
        public string Apellidos { get; set; }

        //Atributo Pais
        [Display(Prompt = "Pais", Description = "Pais del usuario", Name = "Pais:")]
        [Required(ErrorMessage = "Debe existir un pais")]
        [StringLength(maximumLength: Globals.PAIS_MAX_LENGTH, ErrorMessage = "El pais del usuario no puede tener más de {0} caracteres")]
        public string Pais { get; set; }

        //Atributo Telefono
        [Display(Prompt = "Telefono", Description = "Telefono del usuario", Name = "Telefono:")]
        [Required(ErrorMessage = "Debe existir un telefono")]
        [StringLength(maximumLength: Globals.TELEFONO_MAX_LENGTH, ErrorMessage = "El telefono del usuario no puede tener más de {0} caracteres")]
        public int Telefono { get; set; }

        //Atributo Puntuacion
        [Display(Prompt = "Puntuacion", Description = "Puntuacion del usuario", Name = "Puntuacion:")]
        [Required(ErrorMessage = "Debe existir un puntuacion")]
        [StringLength(maximumLength: Globals.PUNTUACION_MAX_LENGTH, ErrorMessage = "El puntuacion del usuario no puede tener más de {0} caracteres")]
        [Range(Globals.PUNTUACION_MIN, Globals.PUNTUACION_MAX,
           ErrorMessage = "{0} debe estar entre {1} y {2}")]
        public int Puntuacion { get; set; }

        //Atributo Contrasenya
        [Display(Prompt = "Contraseña", Description = "Contraseña del usuario", Name = "Contraseña:")]
        [Required(ErrorMessage = "Debe existir un contraseña")]
        [StringLength(maximumLength: Globals.CONTRASENYA_MAX_LENGTH, ErrorMessage = "El contraseña del usuario no puede tener más de {0} caracteres")]
        public string Contrasenya { get; set; }

        //Atributo Nombreusuario
        [Display(Prompt = "Nickname", Description = "Nickname del usuario", Name = "Nickname:")]
        [Required(ErrorMessage = "Debe existir un nickname")]
        [StringLength(maximumLength: Globals.NOMBREUSUARIO_MAX_LENGTH, ErrorMessage = "El nickname del usuario no puede tener más de {0} caracteres")]
        public string Nombreusuario { get; set; }

        //Atributo FechaRegistro
        [HiddenInput(DisplayValue = false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Prompt = "Fecha", Description = "Fecha del usuario", Name = "Fecha:")]
        [Required(ErrorMessage = "Debe de indicar una fecha para el usuario")]
        public Nullable<DateTime> Fecha { get; set; }

        //Atributo Recibe
        [ScaffoldColumn(false)]
        [Display(Prompt = "Mensajes recibidos", Description = "Mensajes recibidos", Name = "Mensajes recibidos")]
        public IList<MensajeDTO> Recibe { get; set; }
    }
}