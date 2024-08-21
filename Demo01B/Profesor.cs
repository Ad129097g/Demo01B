using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Profesor : Persona
    {
        public int Sueldo { get; set; }
        
        public int SueldoNeto(){

            int sueldoneto = Sueldo * (8 / 100);

            if(Sueldo< 2000)
            {
                sueldoneto = Sueldo * (20 / 100);
            } else
            {
                sueldoneto = Sueldo * (50 / 100);
            }
            return sueldoneto;
        }

    }
}
