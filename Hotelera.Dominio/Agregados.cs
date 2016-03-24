﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    class Agregados
    {
        public int ID_Agregados { get; set; }
        public virtual Servicios ID_Servicios { get; set; }

        public static Agregados Guardar(Servicios id_serv)
        {
            return new Agregados()
            {
                ID_Servicios = id_serv
            };
        }
        public static Agregados Modificar(int id_agreg,Servicios id_serv)
        {
            return new Agregados()
            {
                ID_Agregados = id_agreg,
                ID_Servicios = id_serv
            };
        }
        public static Agregados Eliminar(int id_agreg)
        {
            return new Agregados()
            {
                ID_Agregados = id_agreg
            };
        }
    }
}