using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code10Coffe
{
     public  class Proceso
    {
        public void DibujarNombre()
        {
            Console.Clear();
            Console.Write("Escribe un nombre  ");
            string Nombre = Console.ReadLine().ToUpper();
            Console.WriteLine();

            foreach (char letra in Nombre) 
            {
                switch (letra) 
                {
                    #region  Case

                    case 'A':
                        Console.WriteLine("  *  ");
                        Console.WriteLine(" * * ");
                        Console.WriteLine("*****");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        break;

                    case 'B':
                        Console.WriteLine("**** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("**** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("**** ");
                        break;

                    case 'C':
                        Console.WriteLine(" ****");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        Console.WriteLine(" ****");
                        break;

                    case 'D':
                        Console.WriteLine("**** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("**** ");
                        break;

                    case 'E':
                        Console.WriteLine("*****");
                        Console.WriteLine("*    ");
                        Console.WriteLine("**** ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*****");
                        break;

                    case 'F':
                        Console.WriteLine("*****");
                        Console.WriteLine("*    ");
                        Console.WriteLine("**** ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        break;

                    case 'G':
                        Console.WriteLine(" ****");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*  **");
                        Console.WriteLine("*   *");
                        Console.WriteLine(" ****");
                        break;

                    case 'H':
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*****");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        break;

                    case 'I':
                        Console.WriteLine(" *** ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine(" *** ");
                        break;

                    case 'J':
                        Console.WriteLine("  ***");
                        Console.WriteLine("   * ");
                        Console.WriteLine("   * ");
                        Console.WriteLine("*  * ");
                        Console.WriteLine(" *** ");
                        break;

                    case 'K':
                        Console.WriteLine("*   *");
                        Console.WriteLine("*  * ");
                        Console.WriteLine("***  ");
                        Console.WriteLine("*  * ");
                        Console.WriteLine("*   *");
                        break;

                    case 'L':
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*****");
                        break;

                    case 'M':
                        Console.WriteLine("*   *");
                        Console.WriteLine("** **");
                        Console.WriteLine("* * *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        break;

                    case 'N':
                        Console.WriteLine("*   *");
                        Console.WriteLine("**  *");
                        Console.WriteLine("* * *");
                        Console.WriteLine("*  **");
                        Console.WriteLine("*   *");
                        break;

                    case 'O':
                        Console.WriteLine(" *** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine(" *** ");
                        break;

                    case 'P':
                        Console.WriteLine("**** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("**** ");
                        Console.WriteLine("*    ");
                        Console.WriteLine("*    ");
                        break;

                    case 'Q':
                        Console.WriteLine(" *** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*  **");
                        Console.WriteLine(" ****");
                        break;

                    case 'R':
                        Console.WriteLine("**** ");
                        Console.WriteLine("*   *");
                        Console.WriteLine("**** ");
                        Console.WriteLine("*  * ");
                        Console.WriteLine("*   *");
                        break;

                    case 'S':
                        Console.WriteLine(" ****");
                        Console.WriteLine("*    ");
                        Console.WriteLine(" *** ");
                        Console.WriteLine("    *");
                        Console.WriteLine("**** ");
                        break;

                    case 'T':
                        Console.WriteLine("*****");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        break;

                    case 'U':
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine(" *** ");
                        break;

                    case 'V':
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine(" * * ");
                        Console.WriteLine("  *  ");
                        break;

                    case 'W':
                        Console.WriteLine("*   *");
                        Console.WriteLine("*   *");
                        Console.WriteLine("* * *");
                        Console.WriteLine("** **");
                        Console.WriteLine("*   *");
                        break;

                    case 'X':
                        Console.WriteLine("*   *");
                        Console.WriteLine(" * * ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine(" * * ");
                        Console.WriteLine("*   *");
                        break;

                    case 'Y':
                        Console.WriteLine("*   *");
                        Console.WriteLine(" * * ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine("  *  ");
                        break;

                    case 'Z':
                        Console.WriteLine("*****");
                        Console.WriteLine("   * ");
                        Console.WriteLine("  *  ");
                        Console.WriteLine(" *   ");
                        Console.WriteLine("*****");
                        break;

                    default:
                        Console.WriteLine("Character not supported.");
                        break;

                        #endregion

                }
                Console.WriteLine();
            }


       




            Console.WriteLine("Presiona Enter para volver al menú.");
            Console.ReadLine();
        }
        public void DibujarTriangulo()
        {
            Console.Clear();
            Console.Write("Escribe la altura del triángulo: ");
            if (int.TryParse(Console.ReadLine(), out int altura))
            {
                for (int i = 1; i <= altura; i++)
                {
                    Console.WriteLine(new string('*', i));
                }

            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            Console.WriteLine("Presiona Enter para volver al menú.");
            Console.ReadLine();
        }

        public void DibujarRectangulo()
        {
            Console.Clear();
            Console.Write("Escribe la altura del Rectangulo: ");
            if (int.TryParse(Console.ReadLine(), out int altura))
            {
                for (int i = 1; i < altura; i++)
                {
                    Console.WriteLine(new string('*', altura));
                }

            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            Console.WriteLine("Presiona Enter para volver al menú.");
            Console.ReadLine();
        }

        public void CadenaName() 
        {
            Console.WriteLine("Cual es tu nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine($"Tu nombre es { Nombre.ToUpper()} ");

        }

        public void Inicio() 
        {
            Console.WriteLine("Cual es tu primer numero");
            string NumeroUno = Console.ReadLine();
            Console.WriteLine("Cual es tu primer Segundo");
            string NumeroDos = Console.ReadLine();
            Console.WriteLine($"Tu resultado es: "+ Calculadora(NumeroUno, NumeroDos));
        }

        private float Calculadora (string a, string b )
        {
            float Respuesta = 0;

            try 
            {
                 Respuesta = float.Parse(a) + float.Parse(b);

            }
            catch (Exception valorError)
            { 
            
            }



            return Respuesta;
        }


        public void Cadena() 
        {
            string nombre = "Juan";

            int edad = 25;


            // Usando String.Format("");
            string mensaje = string.Format("Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);

            // Usando el operador 
            string mensaje1 = "Hola, mi nombre es " + nombre + " y tengo " + edad + " años.";

            // Usando string.Concat ("",variable)
            string mensaje2 = string.Concat("Hola, mi nombre es ", nombre, " y tengo ", edad, " años.");

            Console.WriteLine(mensaje);
            Console.WriteLine(mensaje1);
            Console.WriteLine(mensaje2);
            Console.ReadLine();

        }

        public void Juego() {

             
            // Lista de palabras para el juego
            string[] palabras = { "programacion", "csharp", "computadora", "juego", "codigo" };
           
            Random random = new Random();
            string palabraSecreta = palabras[random.Next(palabras.Length)];

            // Variables de estado
            char[] palabraOculta = new string('_', palabraSecreta.Length).ToCharArray();
            List<char> letrasIncorrectas = new List<char>();
            int intentosRestantes = 6;

            Console.WriteLine("¡Bienvenido al juego de Palabras!");

            while (intentosRestantes > 0 && new string(palabraOculta) != palabraSecreta)
            {
                Console.WriteLine("\nPalabra: " + new string(palabraOculta));
                Console.WriteLine("Letras incorrectas: " + string.Join(", ", letrasIncorrectas));
                Console.WriteLine("Intentos restantes: " + intentosRestantes);

                Console.Write("Adivina una letra: ");
                char letra = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (palabraSecreta.Contains(letra))
                {
                    Console.WriteLine("¡Bien hecho! La letra está en la palabra.");
                    for (int i = 0; i < palabraSecreta.Length; i++)
                    {
                        if (palabraSecreta[i] == letra)
                        {
                            palabraOculta[i] = letra;
                        }
                    }
                }
                else
                {
                    if (!letrasIncorrectas.Contains(letra))
                    {
                        letrasIncorrectas.Add(letra);
                        intentosRestantes--;
                        Console.WriteLine("Letra incorrecta.");
                    }
                    else
                    {
                        Console.WriteLine("Ya intentaste esa letra.");
                    }
                }
            }

            if (new string(palabraOculta) == palabraSecreta)
            {
                Console.WriteLine("\n¡Felicidades! Adivinaste la palabra: " + palabraSecreta);
            }
            else
            {
                Console.WriteLine("\nLo siento, te quedaste sin intentos. La palabra era: " + palabraSecreta);
            }
        }

        public void Saludar()
        {


            Console.WriteLine("¡Hola! Bienvenido al programa.");
        }

        // Función con parámetros y sin retorno
        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // Función con parámetros y retorno
        public int Sumar(int a, int b)
        {
            int adicion = 5;

            int resultado = 0;


            resultado = (a + b) * adicion;




            return resultado;
        }

        // Función que demuestra sobrecarga (misma función, diferentes parámetros)
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        // Función con paso de parámetros por referencia
        public void Doblar(ref int numero)
        {
            numero *= 2;
        }

        public int SumaConFor() 
        {

            int Suma = 0;
            for (int i = 1; i <= 10; i++) 
             Suma += i;
            return Suma;
        }

        public int SumaConwhile()
        {

            int Suma = 0;
            int Contador = 1;

            while (Contador <= 10)
            {
                Suma += Contador;
                Contador++;
            }
            return Suma;
        }

        public int SumaConDOwhile()
        {

            int Suma = 0;
            int Contador = 1;

            do
            {
                Suma += Contador;
                Contador++;
            } while (Contador <= 10);

            return Suma;
        }



    }
}
