using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Cliente : Persona
    {
        public int ID_Cliente { get; private set; }
        public string Estado_Cliente { get; private set; }

        public static Cliente Registrar(string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli, string estado_cli)
        {
            return new Cliente()
            {
                ///Nombre_Persona = nomb_cli,
                ///Apellido_Persona = ape_cli,
                ///Documento_Cliente = doc_cli,
                ///Celular_Cliente = cel_cli,
                ///Email_Cliente = email_cli,
                Estado_Cliente = estado_cli
            };
        }
        public void Actualizar(int id_cli, string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli, string estado_cli)
        {
            ID_Cliente = id_cli;
            ///Nombre_Cliente = nomb_cli;
            ///Apellido_Cliente = ape_cli;
            ///Documento_Cliente = doc_cli;
            ///Celular_Cliente = cel_cli;
            ///Email_Cliente = email_cli;
            Estado_Cliente = estado_cli;
        }
        public void Bloquear()
        {
            Estado_Cliente = "INACTIVO";
        }
        public void solicitarServicio() { }
        public void checkarHabitacionesDisponibles() { }
        public void solicitarExtension() { }
    }
}
