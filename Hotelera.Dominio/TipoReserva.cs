using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    class TipoReserva
    {
        public int ID_TipoReserva { get; set; }
        public string Nombre_TipoReserva { get; set; }

        public static TipoReserva Guardar(string nomb_tiporeserva)
        {
            return new TipoReserva()
            {
                Nombre_TipoReserva = nomb_tiporeserva
            };
        }
        public static TipoReserva Modificar(int id_tiporeserva,string nomb_tiporeserva)
        {
            return new TipoReserva()
            {
                ID_TipoReserva = id_tiporeserva,
                Nombre_TipoReserva = nomb_tiporeserva
            };
        }
        public static TipoReserva Eliminar(int id_tiporeserva)
        {
            return new TipoReserva()
            {
                ID_TipoReserva = id_tiporeserva
            };
        }
    }
}
