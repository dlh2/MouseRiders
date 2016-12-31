using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MRWeb.Models
{
    public static class Globals
    {
        public static String s_Name = "Mike"; // Modifiable in Code
        public const Int32 USUARIO_MAX_LENGTH = 30; // Unmodifiable
        public const String ERROR_USUARIO_MAX_LENGTH = "El nombre del usuario no puede tener más de  caracteres"; // Unmodifiable
        public const Int32 COMENTARIO_MAX_LENGTH = 200; // Unmodifiable
        public const Int32 PUNTUACION_MIN = -5; // Unmodifiable
        public const Int32 PUNTUACION_MAX = 5; // Unmodifiable

        public const Int32 EMAIL_MAX_LENGTH = 254; // IETF RFC 3696
        public const Int32 NOMBRE_MAX_LENGTH = 85; //Taumatawhakatangi­hangakoauauotamatea­turipukakapikimaunga­horonukupokaiwhen­uakitanatahu (85 letters)
        public const Int32 APELLIDOS_MAX_LENGTH = 170; // Nombre x 2?
        public const Int32 PAIS_MAX_LENGTH = 60; // United Kingdom of Great Britain and Northern Ireland
        public const Int32 TELEFONO_MAX_LENGTH = 50; // + for country code () for area code x + 6 numbers for Extension extension (so make it 8 {space}) spaces between groups (i.e. in American phones +x xxx xxx xxxx = 3 spaces)
        public const Int32 PUNTUACION_MAX_LENGTH = 1; // Unmodifiable
        public const Int32 CONTRASENYA_MAX_LENGTH = 15; // Unmodifiable
        public const Int32 NOMBREUSUARIO_MAX_LENGTH = USUARIO_MAX_LENGTH; // Unmodifiable
        public const Int32 CREADOR_MAX_LENGTH = USUARIO_MAX_LENGTH; // Unmodifiable
        public const Int32 TITULO_MAX_LENGTH = 200; // modifiable
        public const Int32 CONTENIDO_MAX_LENGTH = 40; // modifiable
        public const Int32 DESCRIPCION_MAX_LENGTH = 300; // modifiable

    }
}