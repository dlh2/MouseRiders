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
    public class PermisoAssembler
    {
        public PermisoDTO Convert(PermisoEN per)
        {
            PermisoDTO perDTO = null;
            if (per != null)
            {
                perDTO = new PermisoDTO();
                //perDTO.Rol = per.rol;
                //perDTO.Permiso = per.permiso;
                perDTO.Permisos = per.Permisos;
            }
            return perDTO;
        }
        public PermisoDTO ConvertConComentario_Articulo(PermisoEN us)
        {
            PermisoDTO usDTO = this.Convert(us);
            if (us != null)
            {
                usDTO.Tiene = null;
                IList<UsuarioEN> Recibe = us.Pertenece;
                if (Recibe != null)
                {
                    usDTO.Tiene = new List<UsuarioDTO>();
                    foreach (UsuarioEN entry in Recibe)
                        usDTO.Tiene.Add(new UsuarioAssembler().Convert(entry));
                }
            }
            return usDTO;
        }
        
    }
}