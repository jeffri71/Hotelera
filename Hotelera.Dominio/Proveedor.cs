using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Proveedor
    {
        
        public int ID_Proveedor { get; private set; }
        public string Nombre_Proveedor { get; private set; }
        public string Direccion_Proveedor { get; private set; }
        public string Telefono_Proveedor { get; private set; }
        public string Estado_Proveedor { get; private set; }

        public static Proveedor Registrar(string nomb_pro, string direc_pro, string telef_pro,string estado_provee)
        {
            return new Proveedor()
            {
                Nombre_Proveedor = nomb_pro,
                Direccion_Proveedor = direc_pro,
                Telefono_Proveedor = telef_pro,
                Estado_Proveedor = estado_provee
            };
        }
        public void Actualizar(int id_prov,string nomb_pro, string direc_pro, string telef_pro, string estado_provee)
        {
            ID_Proveedor = id_prov;
            Nombre_Proveedor = nomb_pro;
            Direccion_Proveedor = direc_pro;
            Telefono_Proveedor = telef_pro;
            Estado_Proveedor = estado_provee;            
        }
        public void Anular()
        {
            Estado_Proveedor = "INACTIVO";
        }
    }
}
