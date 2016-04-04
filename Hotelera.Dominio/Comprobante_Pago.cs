using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class Comprobante_Pago
    {
        public int ID_Comprobante { get; private set; }
        public string Nro_Comprobante { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public string Cantidad_Unitaria { get; private set; }
        public double Sub_Total { get; private set; }
        public int IGV { get; private set; }
        public double Total_Final { get; private set; }
        public virtual Estado_Comprobante ID_EstadoComprobante { get; private set; }

    }
}