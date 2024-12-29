using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code10Coffe
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Saludar() 
        {
            Console.WriteLine($"Hola  yo soy  {Nombre.ToUpper()} y tengo {Edad} años ");
        }

    }
}
