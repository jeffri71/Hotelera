using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Personal
    {
        public int ID_Personal { get; private set; }
        public string Nombre_Personal { get; private set; }
        public string Apellido_Personal { get; private set; }
        public string Genero_Personal { get; private set; }
        public int DNI_Personal { get; private set; }
        public string Telefono_Personal { get; private set; }
        public string Email_Personal { get; private set; }
        public string Direccion_Personal { get; private set; }
        public virtual Cargo ID_Cargo { get; private set; }
        public string Estado_Personal { get; private set; }

        public static Personal Registrar(string nomb_pers, string ape_pers,string gen_pers, int dni_pers, string telef_pers, string email_pers, string direc_pers, Cargo id_carg,string estado_pers)
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
                ID_Cargo = id_carg,
                Estado_Personal = estado_pers
            };
        }
        public void Actualizar(int id_pers,string nomb_pers, string ape_pers, string gen_pers, int dni_pers, string telef_pers, string email_pers, string direc_pers, Cargo id_carg, string estado_pers)
        {
            ID_Personal = id_pers;
            Nombre_Personal = nomb_pers;
            Apellido_Personal = ape_pers;
            Genero_Personal = gen_pers;
            DNI_Personal = dni_pers;
            Telefono_Personal = telef_pers;
            Email_Personal = email_pers;
            Direccion_Personal = direc_pers;
            ID_Cargo = id_carg;
            Estado_Personal = estado_pers;
        }
        public void Anular()
        {
            Estado_Personal = "INACTIVO";
        }
    }
}
