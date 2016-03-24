using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Cargo
    {
        public int ID_Cargo { get; private set; }
        public string Nombre_Cargo { get; private set; }
        public string Descripcion_Cargo { get; private set; }
        public decimal Sueldo_Cargo { get; private set; }
        public string Estado_Cargo { get; set; }

        public static Cargo Guardar (string nomb_carg, string descrip_carg, decimal sueld,string estado_carg)
        {
            return new Cargo()
            {
                Nombre_Cargo = nomb_carg,
                Descripcion_Cargo = descrip_carg,
                Sueldo_Cargo = sueld,
                Estado_Cargo = estado_carg
            };
        }
        public void Modificar(int id_carg,string nomb_carg, string descrip_carg, decimal sueld,string estado_carg)
        {
            {
            ID_Cargo = id_carg;
            Nombre_Cargo = nomb_carg;
            Descripcion_Cargo = descrip_carg;
            Sueldo_Cargo = sueld;
            Estado_Cargo = estado_carg;
            }
        }
        public void Eliminar()
        {
            Estado_Cargo = "ELIMINADO";
        }
    }
}
