using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operador;

            //Enviamos un mensaje de bienvenida y una descripcion del programa 

            Console.WriteLine("Bienvenido a Nuestro Programa");
            Console.WriteLine("Este Programa Permite Operaciones Basicas Sobre Dos Numeros");
            Console.WriteLine("----------------------");

            Console.WriteLine("De el valor del primer Numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("De el valor del segundo Numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique la operacion(*,+,-,/)");
            operador = char.Parse(Console.ReadLine());
            /*identificamos el tipo de operacion a realizar haciendo uso de condicional IF*/

            if (operador == '*')
            {
                Console.WriteLine("la multiplicacion es de: " + (num1 * num2));
            }
            if (operador == '*')
            {
                Console.WriteLine("la division es de: " + (num1 * num2));
            }
            Console.ReadLine();

            switch (operador)
            {
                case '*':
                    Console.WriteLine("la Multiplicacion es de: " + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("la Division  es de: " + (num1 / num2));
                    break;

                case '+':

                default:
                    Console.WriteLine("No es Una Opcion Valida");
                    break;
            }
            Console.ReadLine();
                  
            }


        }
    }
}
