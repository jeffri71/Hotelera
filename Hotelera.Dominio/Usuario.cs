using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Usuario
    {
        public int ID_usu { get; set; }
        public virtual Personal id_Personal { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña_Usuario { get; set; }
        public virtual Estado ID_Estado { get; set; }

        public static Usuario Guardar(Personal id_pers, string nomb_usu, string contra_usu, Estado id_estad)
        {
            return new Usuario()
            {
                id_Personal = id_pers,
                Nombre_Usuario = nomb_usu,
                Contraseña_Usuario = contra_usu,
                ID_Estado = id_estad
            };
        }
        public void Modificar(int id_us,Personal id_pers, string nomb_usu, string contra_usu, Estado id_estad)
        {
            //return new Usuario()
            //{
            ID_usu = id_us;
            id_Personal = id_pers;
            Nombre_Usuario = nomb_usu;
            Contraseña_Usuario = contra_usu;
            ID_Estado = id_estad;
            //};
        }
        public void Eliminar(int id_us)
        {
            //return new Usuario()
           // {
                ID_usu = id_us;
            // };
        }
    }
}
