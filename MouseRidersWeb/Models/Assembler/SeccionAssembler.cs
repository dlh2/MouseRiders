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
    public class SeccionAssembler
    {
     
        public SeccionDTO Convert(SeccionEN sec)
        {
            SeccionDTO secDTO = null;
            if (sec != null)
            {
                if (sec.Nombre.Equals("NoticiasPC"))
                {
                    return null;
                }
                secDTO = new SeccionDTO();
                secDTO.Seccion = sec.Seccion;
                secDTO.Nombre = sec.Nombre;
            }
            return secDTO;
        }
        public SeccionDTO ConvertConArticulo(SeccionEN sec)
        {
            SeccionDTO secDTO = null;
            if (sec != null)
            {
                secDTO = this.Convert(sec);
                if (secDTO != null)
                {
                    secDTO.Tiene = null;
                }
                else
                {
                    return secDTO;
                }
                IList<ArticuloEN> Recibe = sec.Tiene;
                if (Recibe != null)
                {
                    secDTO.Tiene = new List<ArticuloDTO>();
                    foreach (ArticuloEN entry in Recibe)
                        secDTO.Tiene.Add(new ArticuloAssembler().Convert(entry));
                }
            }
            return secDTO;
        }
        public SeccionDTO ConvertConArticuloNum(SeccionEN sec,int comienzo, int cantidad)
        {
            SeccionDTO secDTO = null;
            if (sec != null)
            {
                secDTO = this.Convert(sec);
                if (secDTO != null)
                {
                    secDTO.Tiene = null;
                }
                else
                {
                    return secDTO;
                }
                IList<ArticuloEN> Recibe = sec.Tiene;
                if (Recibe != null)
                {
                    secDTO.Tiene = new List<ArticuloDTO>();
                    for (int i = comienzo; i < Recibe.Count && i <= (comienzo+cantidad); i++)
                    {
                        secDTO.Tiene.Add(new ArticuloAssembler().Convert(Recibe[i]));
                    }
                    for (int i = comienzo+comienzo; i < Recibe.Count && i <= (comienzo+comienzo + cantidad); i++)
                    {
                        secDTO.hayMasArticulos = true;
                    }
                }
            }
            return secDTO;
        }

        public SeccionDTO ConvertNoticia(SeccionEN sec)
        {
            SeccionDTO secDTO = null;
            if (sec != null)
            {
                if (!sec.Nombre.Equals("NoticiasPC"))
                {
                    return null;
                }
                secDTO = new SeccionDTO();
                secDTO.Seccion = sec.Seccion;
                secDTO.Nombre = sec.Nombre;
            }
            return secDTO;
        }

        public SeccionDTO ConvertNoticiaConArticulo(SeccionEN sec)
        {
            SeccionDTO secDTO = null;
            if (sec != null)
            {
                secDTO = this.ConvertNoticia(sec);
                if (secDTO != null)
                {
                    secDTO.Tiene = null;
                }
                IList<ArticuloEN> Recibe = sec.Tiene;
                if (Recibe != null)
                {
                    secDTO.Tiene = new List<ArticuloDTO>();
                    foreach (ArticuloEN entry in Recibe)
                        secDTO.Tiene.Add(new ArticuloAssembler().Convert(entry));
                }
            }
            return secDTO;
        }

    }
}