using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Agregados
    {
        public int ID_Agregados { get; set; }
        public virtual Servicios ID_Servicios { get; set; }
        public string Estado_Servicios { get; set; }

        public static Agregados Guardar(Servicios id_serv,string estado_serv)
        {
            return new Agregados()
            {
                ID_Servicios = id_serv,
                Estado_Servicios = estado_serv
            };
        }
        public void Modificar(int id_agreg,Servicios id_serv, string estado_serv)
        {
            ID_Agregados = id_agreg;
            ID_Servicios = id_serv;
            Estado_Servicios = estado_serv;
        }
        public void Eliminar()
        {
            Estado_Servicios = "ELIMINADO";
        }
    }
}
