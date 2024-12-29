using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code10Coffe
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Proceso  Objeto = new Proceso();

            while (true) 
            {
                Console.WriteLine("Menu ");

                Console.WriteLine("1.- Triangulo ");
                Console.WriteLine("2.- Nombre ");
                Console.WriteLine("3.- Rectangulo ");

                string opcion=Console.ReadLine();

                switch (opcion) 
                {
                    case "1":
                        Objeto.DibujarTriangulo();
                        break;
                    case "2":
                        Objeto.DibujarNombre();
                        break;
                    case "3":
                        Objeto.DibujarRectangulo();
                        break;
                }


            }

            Objeto.DibujarTriangulo();

            /*
            #region Lista 

            List<Persona> personas = new List<Persona>();
            string continuar = "s";

            while (continuar == "s")
            {
                Persona persona = new Persona();
                Console.Write("Nombre: ");
                persona.Nombre = Console.ReadLine();
                Console.Write("Edad: ");
                persona.Edad = int.Parse(Console.ReadLine());

                personas.Add(persona);

                Console.Write("¿Deseas registrar otra persona? (s/n): ");
                continuar = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nSaludando a las personas:");
            foreach (Persona persona in personas)
            {
                persona.Saludar();
            }


            #endregion


            #region Arreglos
            Console.Write(" Cuantas personas son: ");
          int  total= int.Parse(Console.ReadLine());

            Persona[] Personas = new Persona[total];

            for (int i = 0; i < Personas.Length; i++)
            {
                Personas[i] = new Persona();
                Console.WriteLine("Nombre: ");
                Personas[i].Nombre = Console.ReadLine();
                Console.Write(" Edad: ");
                Personas[i].Edad = int.Parse(Console.ReadLine());
                Personas[i].Saludar();

            }

            #endregion


            #region Objeto
            Persona PersonaUno = new Persona();
            Console.WriteLine("Nombre: ");
            PersonaUno.Nombre = Console.ReadLine();
            Console.Write(" Edad: ");
            PersonaUno.Edad = int.Parse(Console.ReadLine());
            PersonaUno.Saludar();

            Persona PersonaDos = new Persona();
            Console.WriteLine("Nombre: ");
            PersonaDos.Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            PersonaDos.Edad = int.Parse(Console.ReadLine());
            PersonaDos.Saludar();
            #endregion

           

            Console.WriteLine("La  Suma con bucle for: " + objeto.SumaConFor());

            Console.WriteLine("La  Suma con bucle while: " + objeto.SumaConwhile());

            Console.WriteLine("La  Suma con bucle DO while: " + objeto.SumaConDOwhile());
            //Console.ReadKey().KeyChar;
          


            // Llamando a la función sin parámetros
            objeto.Saludar();

            // Llamando a la función con un parámetro
            objeto.MostrarMensaje("Este es un mensaje personalizado.");



            // Llamando a la función con retorno
          //  int sumaEnteros = objeto.Sumar(3, 5);
            Console.WriteLine("La suma de 3 y 5 es:"+"  " + objeto.Sumar(3, 5));

            // Llamando a la sobrecarga de la función
            double sumaDecimales = objeto.Sumar(2.5, 3.7);
            Console.WriteLine($"La suma de 2.5 y 3.7 es: {sumaDecimales}");

            */






            Console.ReadLine();

        }
    }
}
