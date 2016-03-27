using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Estado
    {
        public int ID_Estado { get; private set; }
        public string Nombre_Estado { get; private set; }        

        public static Estado insertarEstado(string nomb_estad)
        {
            return new Estado()
            {
                Nombre_Estado = nomb_estad
            };
        }
        public void actualizarEstado(int id_est, string nomb_estad)
        {
            ID_Estado = id_est;
            Nombre_Estado = nomb_estad;
        }
        public void eliminarEstado(int id_est)
        {
           
        }
    }
}
