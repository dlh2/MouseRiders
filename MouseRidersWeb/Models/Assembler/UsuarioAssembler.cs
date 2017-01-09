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
                usDTO.FotoUsuario = us.Fotoperfil;
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
        public UsuarioDTO ConvertConCorreoEnviado(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Enviado = null;
                }
                IList<MensajeEN> Envia = us.Envia;
                if (Envia != null)
                {
                    usDTO.Enviado = new List<MensajeDTO>();
                    foreach (MensajeEN entry in Envia)
                        usDTO.Enviado.Add(new MensajeAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        public UsuarioDTO ConvertConPermisos(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Permisos_usu = null;
                }
                IList<PermisoEN> Permisos = us.Tiene;
                if (Permisos != null)
                {
                    usDTO.Permisos_usu = new List<PermisoDTO>();
                    foreach (PermisoEN entry in Permisos)
                        usDTO.Permisos_usu.Add(new PermisoAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        public UsuarioDTO ConvertConRecompensas(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Recompensa_usu = null;
                }
                IList<RecompensaEN> Envia = us.Obtiene;
                if (Envia != null)
                {
                    usDTO.Recompensa_usu = new List<RecompensaDTO>();
                    foreach (RecompensaEN entry in Envia)
                        usDTO.Recompensa_usu.Add(new RecompensaAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        public UsuarioDTO ConvertConDenunciasRecibidas(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Denuncia_recibida = null;
                }
                IList<DenunciaEN> Envia = us.RecibeD;
                if (Envia != null)
                {
                    usDTO.Denuncia_recibida = new List<DenunciaDTO>();
                    foreach (DenunciaEN entry in Envia)
                        usDTO.Denuncia_recibida.Add(new DenunciaAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        public UsuarioDTO ConvertConDenunciasEnviadas(UsuarioEN us)
        {
            UsuarioDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Denuncia_creada = null;
                }
                IList<DenunciaEN> Envia = us.CreaD;
                if (Envia != null)
                {
                    usDTO.Denuncia_creada = new List<DenunciaDTO>();
                    foreach (DenunciaEN entry in Envia)
                        usDTO.Denuncia_creada.Add(new DenunciaAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
    }
}
