using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public virtual Habitacion ID_Habitacion { get; set; }
        public virtual Cliente ID_Cliente { get; set; }
        public virtual Usuario ID_Usuario { get; set; }
        public virtual TipoReserva ID_TipoReserva { get; set; }
        public virtual MedioReserva ID_MedioReserva { get; set; }
        public string Estado_Reserva { get; set; }
        public DateTime Fecha_Reserva { get; set; }
        public DateTime Fecha_IngresoReserva { get; set; }
        public DateTime Fecha_SalidaReserva { get; set; }
        public virtual Agregados ID_Agregados { get; set; }

        public static Reserva Guardar(Habitacion id_hab, Cliente id_client,Usuario id_usu,TipoReserva id_tipreserv, MedioReserva id_medioreserv,string estado_reserv,DateTime fecha_reserv, DateTime fecha_ingreso, DateTime fecha_salida, Agregados id_agregad)
        {
            return new Reserva()
            {
                ID_Habitacion = id_hab,
                ID_Cliente = id_client,
                ID_Usuario = id_usu,
                ID_TipoReserva = id_tipreserv,
                ID_MedioReserva = id_medioreserv,
                Estado_Reserva = estado_reserv,
                Fecha_Reserva = fecha_reserv,
                Fecha_IngresoReserva = fecha_ingreso,
                Fecha_SalidaReserva = fecha_salida,
                ID_Agregados = id_agregad
            };
        }
        public void Modificar(int id_reserv,Habitacion id_hab, Cliente id_client, Usuario id_usu, TipoReserva id_tipreserv, MedioReserva id_medioreserv, string estado_reserv, DateTime fecha_reserv, DateTime fecha_ingreso, DateTime fecha_salida, Agregados id_agregad)
        {
            /*return new Reserva()
            {*/
            ID_Reserva = id_reserv;
                ID_Habitacion = id_hab,
                ID_Cliente = id_client,
                ID_Usuario = id_usu,
                ID_TipoReserva = id_tipreserv,
                ID_MedioReserva = id_medioreserv,
                Estado_Reserva = estado_reserv,
                Fecha_Reserva = fecha_reserv,
                Fecha_IngresoReserva = fecha_ingreso,
                Fecha_SalidaReserva = fecha_salida,
                ID_Agregados = id_agregad
            //};
        }
        public void Eliminar(int id_reserv)
        {
            /*return new Reserva()
            {
                ID_Reserva = id_reserv
            };*/
        }
    }
}
