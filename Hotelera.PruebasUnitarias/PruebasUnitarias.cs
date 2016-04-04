using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotelera.Dominio;
using Hotelera.Infraestructura;
namespace Hotelera.PruebasUnitarias
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var lo_reserva = Reserva.Guardar(null,null,null,null,null,null,DateTime.Now, DateTime.Now, DateTime.Now, null);
            //lo_reserva.Eliminar(1);
            Cliente objcliente = new Cliente(2, "normal", "Lucas", "Vasquez", "Masculino", "dni", "12345678", "052-455435", "luis.v@hotmail.com", "Ave Jorge Basade #123");
            using (var lo_contexto = new HoteleraContexto())
            {
                lo_contexto.Clientes.Add(lo_cliente);
                lo_contexto.SaveChanges();
            }
            Assert.IsTrue(lo_cliente.CodigoCliente == 1);
        }
    }
}
