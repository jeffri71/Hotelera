using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class MedioReserva
    {
        public int ID_MedioReserva { get; set; }
        public string Nombre_Reserva { get; set; }

        public static MedioReserva Guardar(string nomb_reserv)
        {
            return new MedioReserva()
            {
                Nombre_Reserva = nomb_reserv
            };
        }
        public void Modificar(int id_medio,string nomb_reserv)
        {
           // return new MedioReserva()
            //{
            ID_MedioReserva = id_medio;
            Nombre_Reserva = nomb_reserv;
            // };
        }
        public void Eliminar(int id_medio)
        {
           // return new MedioReserva()
           // {
                ID_MedioReserva = id_medio;
            //};
        }
    }
}
