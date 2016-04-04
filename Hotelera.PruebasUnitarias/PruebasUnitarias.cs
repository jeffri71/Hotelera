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
            Cargo cargo = new Cargo(1,"Recepcionista","Encargado de la atencion del huesped",899,"aceptado");
            Personal objempleado = new Personal(cargo,5, "normal", "Lucas", "Vasquez", "Masculino", "dni", "5555555", "052-455435", "luis.v@hotmail.com", "Ave Jorge Basade #123");
            using (var lo_contexto = new HoteleraContexto())
            {
                lo_contexto.Empleados.Add(objempleado);
                lo_contexto.Cargos.Add(cargo);
                lo_contexto.SaveChanges();
            }
            Assert.IsTrue(objempleado.ID_Personal == 5);
        }
    }
}
