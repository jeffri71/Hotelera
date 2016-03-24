using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    class Personal
    {
        public int ID_Personal { get; set; }
        public string Nombre_Personal { get; set; }
        public string Apellido_Personal { get; set; }
        public string Genero_Personal { get; set; }
        public int DNI_Personal { get; set; }
        public string Telefono_Personal { get; set; }
        public string Email_Personal { get; set; }
        public string Direccion_Personal { get; set; }
        public virtual Cargo ID_Cargo { get; set; }

        public static Personal Guardar(string nomb_pers, string ape_pers,string gen_pers, int dni_pers, string telef_pers, string email_pers, string direc_pers, Cargo id_carg)
        {
            return new Personal()
            {
                Nombre_Personal = nomb_pers,
                Apellido_Personal = ape_pers,
                Genero_Personal = gen_pers,
                DNI_Personal = dni_pers,
                Telefono_Personal = telef_pers,
                Email_Personal = email_pers,
                Direccion_Personal = direc_pers,
                ID_Cargo = id_carg
            };
        }
        public static Personal Modificar(int id_pers,string nomb_pers, string ape_pers, string gen_pers, int dni_pers, string telef_pers, string email_pers, string direc_pers, Cargo id_carg)
        {
            return new Personal()
            {
                ID_Personal = id_pers,
                Nombre_Personal = nomb_pers,
                Apellido_Personal = ape_pers,
                Genero_Personal = gen_pers,
                DNI_Personal = dni_pers,
                Telefono_Personal = telef_pers,
                Email_Personal = email_pers,
                Direccion_Personal = direc_pers,
                ID_Cargo = id_carg
            };
        }
        public static Personal Eliminar(int id_pers)
        {
            return new Personal()
            {
                ID_Personal = id_pers
            };
        }
    }
}
