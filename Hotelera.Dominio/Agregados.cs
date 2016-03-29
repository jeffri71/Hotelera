using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria

namespace Hotelera.Dominio
    //ej
{
    public class Agregados
    {
        public int ID_Agregados { get; private set; }
        public virtual Servicios ID_Servicios { get; private set; }
        public string Estado_Servicios { get; private set; }

        public static Agregados Agregar(Servicios id_serv,string estado_serv)
        {
            return new Agregados()
            {
                ID_Servicios = id_serv,
                Estado_Servicios = estado_serv
            };
        }
        public void Actualizar(int id_agreg,Servicios id_serv, string estado_serv)
        {
            ID_Agregados = id_agreg;
            ID_Servicios = id_serv;
            Estado_Servicios = estado_serv;
        }
        public void Anular()
        {
            Estado_Servicios = "ELIMINADO";
        }
    }
}
