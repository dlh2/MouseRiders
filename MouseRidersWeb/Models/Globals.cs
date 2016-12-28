using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MouseRidersWeb.Models
{
    public static class Globals
    {
        public static String s_Name = "Mike"; // Modifiable in Code
        public const Int32 USUARIO_MAX_LENGTH = 30; // Unmodifiable
        public const String ERROR_USUARIO_MAX_LENGTH = "El nombre del usuario no puede tener más de  caracteres"; // Unmodifiable
        public const Int32 COMENTARIO_MAX_LENGTH = 200; // Unmodifiable
        public const Int32 PUNTUACION_MIN = -5; // Unmodifiable
        public const Int32 PUNTUACION_MAX = 5; // Unmodifiable
    }
}