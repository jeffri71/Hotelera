using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Inventario
    {
        public int ID_Inventario { get; private set; }
        public virtual Proveedor ID_Pro { get; private set; }
        public string Estado_Inventario { get; private set; }

        public static Inventario Registrar(Proveedor id_prov,string estado_inv)
        {
            return new Inventario()
            {
                ID_Pro = id_prov,
                Estado_Inventario = estado_inv
            };
        }
        public void Actualizar(int id_inven,Proveedor id_prov, string estado_inv)
        {
            ID_Inventario = id_inven;
            ID_Pro = id_prov;
            Estado_Inventario = estado_inv;
        }
        public void Anular()
        {
            Estado_Inventario = "ELIMINADO";
        }
    }
}
