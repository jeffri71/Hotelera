using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class MedioReserva
    {
        public int ID_MedioReserva { get; private set; }
        public string Nombre_Reserva { get; private set; }
        public string Estado_MedioReserva { get; private set; }

        public static MedioReserva Registrar(string nomb_reserv, string estado_medioreserv)
        {
            return new MedioReserva()
            {
                Nombre_Reserva = nomb_reserv,
                Estado_MedioReserva = estado_medioreserv
            };
        }
        public void Actualizar(int id_medio,string nomb_reserv, string estado_medioreserv)
        {
           ID_MedioReserva = id_medio;
           Nombre_Reserva = nomb_reserv;
           Estado_MedioReserva = estado_medioreserv;
        }
        public void Anular()
        {
            Estado_MedioReserva = "ELIMINADO";
        }
    }
}
