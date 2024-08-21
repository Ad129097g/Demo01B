using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Persona
    {
        public String Nombres { get; set; }
        public String Apellidos { get; set;}
        public int Edad { get; set; }
        public string NombresCompletos { get; private set; }

        public String MayorDeEdad()
        {
            string mensaje = "Es menor de edad";
            if (Edad > 18)
                mensaje = "Es mayor de edad";
            return mensaje;
        }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }



    }
}
