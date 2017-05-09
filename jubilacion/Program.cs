using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jubilacion
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;
            string genero;


            Console.Write("Ingrese la edad: ");
            edad = Convert.ToInt32(Console.ReadLine());


            Console.Write("Sexo solo minusculas m/f: ");
            genero = Console.ReadLine();



            if (genero == "m" && edad > 65)
            {

                Console.Write("Se puede jubilar");
            }


            else if (genero == "m" && edad < 65)
            {

                Console.Write("No se puede Jubilar");
            }


            else if (genero == "f" && edad > 60)
            {

                Console.Write("Se puede jubilar");

            }


            else
            {
                Console.Write("No se puede Jubilar");
            }



            Console.ReadLine();
        }
    }
}
