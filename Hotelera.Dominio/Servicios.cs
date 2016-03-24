using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Servicios
    {
        public int ID_Servicio { get; set; }
        public string Nombre_Servicio { get; set; }     
        public string Descripcion_Servicio { get; set; }
        public decimal Precio_Servicio { get; set; }
        public string Estado_Servicio { get; set; }
        public static Servicios Guardar(string nomb_serv, string descrip_serv, decimal precio_serv, string estado_serv)
        {
            return new Servicios()
            {
                Nombre_Servicio = nomb_serv,
                Descripcion_Servicio = descrip_serv,
                Precio_Servicio = precio_serv,
                Estado_Servicio = estado_serv
            };
        }
        public void Modificar(int id_serv,string nomb_serv, string descrip_serv, decimal precio_serv, string estado_serv)
        {
            //return new Servicios()
           // {
            ID_Servicio = id_serv;
            Nombre_Servicio = nomb_serv;
            Descripcion_Servicio = descrip_serv;
            Precio_Servicio = precio_serv;
            Estado_Servicio = estado_serv;
            //};
        }
        public void Eliminar(int id_serv)
        {
            //return new Servicios()
            //{
                ID_Servicio = id_serv;
            //};
        }
    }
}
