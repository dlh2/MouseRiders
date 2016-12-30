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
    public class UsuarioAssembler
    {
        public UsuarioDTO Convert(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = new UsuarioDTO();
                usDTO.Id = us.Id;
                usDTO.Email = us.Email;
                usDTO.Nombre = us.Nombre;
                usDTO.Apellidos = us.Apellidos;
                usDTO.Pais = us.Pais;
                usDTO.Telefono = us.Telefono;
                usDTO.Puntuacion = us.Puntuacion;
                usDTO.Fecha = us.FechaRegistro;
                usDTO.Contrasenya = us.Contrasenya;
                usDTO.Nombreusuario = us.Nombreusuario;
            }
            return usDTO;
        }
        public UsuarioDTO ConvertConCorreoRecibido(UsuarioEN us)
        {
            UsuarioDTO usDTO = this.Convert(us);
            if (us != null)
            {
                usDTO.Recibe = null;
                IList<MensajeEN> Recibe = us.Recibe;
                if (Recibe != null)
                {
                    usDTO.Recibe = new List<MensajeDTO>();
                    foreach (MensajeEN entry in Recibe)
                        usDTO.Recibe.Add(new MensajeAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
    }
}
