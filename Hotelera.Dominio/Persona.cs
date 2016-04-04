using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class Persona
    {
        public int ID_Persona { get; private set; }
        public string Nombre_Persona { get; private set; }
        public string Apellido_Persona { get; private set; }
        public string Genero_Persona { get; private set; }
        public string TipoDocumentoPersona { get; private set; }
        public string NumeroDocumentoPersona { get; private set; }
        public string Telefono_Persona { get; private set; }
        public string Email_Persona { get; private set; }
        public string Direccion_Persona { get; private set; }
    }
}