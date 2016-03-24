using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    class Estado
    {
        public int ID_Estado { get; set; }
        public string Nombre_Estado { get; set; }

        public static Estado Guardar(string nomb_estad)
        {
            return new Estado()
            {
                Nombre_Estado = nomb_estad
            };
        }
        public static Estado Modificar(int id_est, string nomb_estad)
        {
            return new Estado()
            {
                ID_Estado = id_est,
                Nombre_Estado = nomb_estad
            };
        }
        public static Estado Eliminar(int id_est)
        {
            return new Estado()
            {
                ID_Estado = id_est  
            };
        }
    }
}
