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
    public class PermisoAssembler
    {
        public PermisoDTO Convert(PermisoEN per)
        {
            PermisoDTO perDTO = null;
            if (per != null)
            {
                perDTO = new PermisoDTO();
                perDTO.Rol = per.PermisoOID.Rol;
                perDTO.Permiso = per.PermisoOID.Permiso;
                perDTO.Permisos = per.Permisos;
            }
            return perDTO;
        }
        public PermisoDTO ConvertConComentario_Articulo(PermisoEN us)
        {
            PermisoDTO usDTO = null;
            if (us != null)
            {
                usDTO = this.Convert(us);
                if (usDTO != null)
                {
                    usDTO.Tiene = null;
                }
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