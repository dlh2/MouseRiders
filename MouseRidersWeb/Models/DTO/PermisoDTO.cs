using MouseRidersGenNHibernate.Enumerated.MouseRiders;
using MouseRidersWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// Definición clase PermisoDTO
namespace MouseRidersWeb.DTO
{
    public class PermisoDTO
    {

        //Atributo Rol
        [ScaffoldColumn(false)]
        [Display(Prompt = "Rol", Description = "Rol del perimiso", Name = "Rol:")]
        [Required(ErrorMessage = "Debe existir un rol")]
        //[StringLength(maximumLength: Globals.TIPO_MAX_LENGTH, ErrorMessage = "El tipo del mensaje no puede tener más de {0} caracteres")]
        public T_RolEnum Rol { get; set; }

        /**
         *	Atributo Permiso
         *	
         */
        [ScaffoldColumn(false)]
        [Display(Prompt = "Permiso", Description = "Permiso", Name = "Permiso:")]
        [Required(ErrorMessage = "Debe tener un permiso")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "El permiso no puede tener más de {0} caracteres")]
        public string Permiso { get; set; }

        /**
         *	Atributo Permisos
         */
        [Display(Prompt = "Permisos", Description = "Permisos", Name = "Permisos:")]
        [Required(ErrorMessage = "Debe tener unos permisos")]
        [StringLength(maximumLength: Globals.TITULO_MAX_LENGTH, ErrorMessage = "Los permisos no puede tener más de {0} caracteres")]
        public string Permisos { get; set; }

        //Atributo Usuario
        [ScaffoldColumn(false)]
        [Display(Prompt = "Usuarios", Description = "Usuarios", Name = "Usuarios")]
        public IList<UsuarioDTO> Tiene { get; set; }

    }
}