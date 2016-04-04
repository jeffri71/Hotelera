using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelera.Dominio;
namespace Hotelera.Dominio
{
    public class Personal : Persona
    {
        public int ID_Personal { get; private set; }
        public virtual Cargo ID_Cargo { get; private set; }
        public string Estado_Personal { get; private set; }
        public virtual Persona Persona { get; private set; }
        public static Personal Registrar(Persona nombre_personal,Cargo id_carg, string estado_pers)
        {
            return new Personal()
            {
                
                ID_Cargo = id_carg,
                Estado_Personal = estado_pers
            };
        }
        public void Actualizar(Cargo id_carg, string estado_pers)
        {
            
            ID_Cargo = id_carg;
            Estado_Personal = estado_pers;
        }
        public void Anular()
        {
            Estado_Personal = "INACTIVO";
        }
    }
}
