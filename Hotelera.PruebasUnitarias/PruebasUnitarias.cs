using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotelera.Dominio;

namespace Hotelera.PruebasUnitarias
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void TestMethod1()
        {
            var lo_reserva = Reserva.Guardar(null,null,null,null,null,null,DateTime.Now, DateTime.Now, DateTime.Now, null);
            //lo_reserva.Eliminar(1);
        }
    }
}
