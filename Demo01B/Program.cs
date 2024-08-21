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
        
            };

            Estudiante estudiante = new Estudiante
            {
                Nombres = "Dave",
                Apellidos = "Santivañez",
                Nota = 20
            };


            Console.WriteLine(persona.NombresCompletos);
            Console.WriteLine("Hola mundo");
            

            Triángulo triángulo = new Triángulo
            {
                 x1 = 1,
                 y1 = 1,

                 x2 = 4,
                 y2 = 1,

                 y3 = 3,
                 x3 = 5,

            };
            triángulo.CalcularLados();

            double área = triángulo.CalcularArea();
            double perímetro = triángulo.CalcularPerimetro();

            Console.WriteLine($"Área: {área}");
            Console.WriteLine($"Perímetro: {perímetro}");

            Console.Read();

        }
    }
}
