using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class TipoReserva
    {
        public int ID_TipoReserva { get; private set; }
        public string Nombre_TipoReserva { get; private set; }

        public static TipoReserva agregarTipoDeReserva(string nomb_tiporeserva)
        {
            return new TipoReserva()
            {
                Nombre_TipoReserva = nomb_tiporeserva
            };
        }
        public void modificarTipoDeReserva(int id_tiporeserva,string nomb_tiporeserva)
        {
            //return new TipoReserva()
            //{
            ID_TipoReserva = id_tiporeserva;
            Nombre_TipoReserva = nomb_tiporeserva;
            // };
        }
        public void eliminarTipoDeReserva(int id_tiporeserva)
        {
            
        }
    }
}
