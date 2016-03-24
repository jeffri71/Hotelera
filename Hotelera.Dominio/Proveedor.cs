using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Proveedor
    {
        public int variablepruebacambio
        public int ID_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Direccion_Proveedor { get; set; }
        public string Telefono_Proveedor { get; set; }
        public string Estado_Proveedor { get; set; }

        public static Proveedor Guardar(string nomb_pro, string direc_pro, string telef_pro,string estado_provee)
        {
            return new Proveedor()
            {
                Nombre_Proveedor = nomb_pro,
                Direccion_Proveedor = direc_pro,
                Telefono_Proveedor = telef_pro,
                Estado_Proveedor = estado_provee
            };
        }
        public void Modificar(int id_prov,string nomb_pro, string direc_pro, string telef_pro, string estado_provee)
        {
            ID_Proveedor = id_prov;
            Nombre_Proveedor = nomb_pro;
            Direccion_Proveedor = direc_pro;
            Telefono_Proveedor = telef_pro;
            Estado_Proveedor = estado_provee;            
        }
        public void Eliminar()
        {
            Estado_Proveedor = "INACTIVO";
        }
    }
}
