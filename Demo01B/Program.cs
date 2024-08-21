using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Program
    {
        static void Main(string[] args)
        {                                                                                                                                                           

            Persona persona = new Persona();
            persona.Nombres = "Nombre";
            persona.Apellidos = "Apellidos";

            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 1;
            triangulo.Base = 2;
            Console.WriteLine(triangulo.CalcularArea());

            persona.AsignarNombresCompletos();

            Persona persona1 = new Persona("Reyna", "Torrico");

            Persona persona2 = new Persona
            {
                Nombres = "Derek",
                Apellidos = "Torrico",
                Edad = 5
            };

            Console.WriteLine(persona.NombresCompletos);
            Console.WriteLine("Hola mundo");
            Console.Read();
        }
    }
}
