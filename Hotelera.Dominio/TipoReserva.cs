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

        public static TipoReserva Registrar_TipoReserva(string nomb_tiporeserva)
        {
            return new TipoReserva()
            {
                Nombre_TipoReserva = nomb_tiporeserva
            };
        }
        public void Actualizar_TipoReserva(int id_tiporeserva,string nomb_tiporeserva)
        {
            ID_TipoReserva = id_tiporeserva;
            Nombre_TipoReserva = nomb_tiporeserva;            
        }
        public void Anular_TipoReserva()
        {
            
        }
    }
}
