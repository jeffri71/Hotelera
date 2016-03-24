using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public int Documento_Cliente { get; set; }
        public string Celular_Cliente { get; set; }
        public string Email_Cliente { get; set; }

        public static Cliente Guardar(string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli)
        {
            return new Cliente()
            {
                Nombre_Cliente = nomb_cli,
                Apellido_Cliente = ape_cli,
                Documento_Cliente = doc_cli,
                Celular_Cliente = cel_cli,
                Email_Cliente = email_cli
            };
        }
        public static Cliente Modificar(int id_cli,string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli)
        {
            return new Cliente()
            {
                ID_Cliente = id_cli,
                Nombre_Cliente = nomb_cli,
                Apellido_Cliente = ape_cli,
                Documento_Cliente = doc_cli,
                Celular_Cliente = cel_cli,
                Email_Cliente = email_cli
            };
        }
        public static Cliente Eliminar(int id_cli)
        {
            return new Cliente()
            {
                ID_Cliente = id_cli
            };
        }

    }
}
