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
                usDTO.FechaRegistro = us.FechaRegistro;
                usDTO.Contrasenya = us.Contrasenya;
                usDTO.Nombreusuario = us.Nombreusuario;
            }
            return usDTO;
        }
        public UsuarioDTO ConvertConCorreoRecibido(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Recibe = null;
                }
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
