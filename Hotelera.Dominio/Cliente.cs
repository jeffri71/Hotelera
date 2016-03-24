using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public int Documento_Cliente { get; set; }
        public string Celular_Cliente { get; set; }
        public string Email_Cliente { get; set; }
        public string Estado_Cliente { get; set; }

        public static Cliente Guardar(string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli,string estado_cli)
        {
            return new Cliente()
            {
                Nombre_Cliente = nomb_cli,
                Apellido_Cliente = ape_cli,
                Documento_Cliente = doc_cli,
                Celular_Cliente = cel_cli,
                Email_Cliente = email_cli,
                Estado_Cliente = estado_cli
            };
        }
        public void Modificar(int id_cli,string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli, string estado_cli)
        {
            ID_Cliente = id_cli;
            Nombre_Cliente = nomb_cli;
            Apellido_Cliente = ape_cli;
            Documento_Cliente = doc_cli;
            Celular_Cliente = cel_cli;
            Email_Cliente = email_cli;
            Estado_Cliente = estado_cli;
        }
        public void Eliminar()
        {
            Estado_Cliente = "INACTIVO";
        }

    }
}
