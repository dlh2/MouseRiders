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
                perDTO.Rol = per.rol;
                perDTO.Permiso = per.permiso;
                perDTO.Permisos = per.Permisos;
            }
            return perDTO;
        }
        
    }
}