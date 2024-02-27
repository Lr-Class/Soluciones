using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeciciosVarios
{
    public class EjerciciosBasicos
    {
        public void MenuBasicos()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU EJERCICIOS BASICOS");
                Console.WriteLine("1. CALCULAR FACTORIAL");
                Console.WriteLine("2. CALCULAR PRODUCTO");
                Console.WriteLine("3. EL CUADRADO DE UN NUMERO");
                Console.WriteLine("4. salir");

                Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Factorial de un numero");
                        CalcularFactorial();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Producto de dos numeros");
                        CalcularProducto();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Cuadrado de un numero");
                        CalcularCuadrado();
                        break;
                }


            } while (op != 4);
            //Console.ReadKey();


        }


        public void CalcularFactorial()
        {
            int numero = 0;
            int resultado = 1;
            Console.Write("digite numero para el calculo = ");
            numero = int.Parse(Console.ReadLine());
            resultado = numero;
            for (int i = 1; i < numero; i++)
            {
                resultado = resultado * i;

            }
            Console.WriteLine($"el factorial de {numero} es {resultado}");
            Console.ReadKey();
        }

        public void CalcularProducto()
        {
            int dato1, dato2;

            Console.Write("Dijite un numero: ");
            dato1 = int.Parse(Console.ReadLine());

            Console.Write("Dijite otro numero: ");
            dato2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"El prodicto de estos numeros es: {dato1 * dato2}");
            Console.ReadKey();
        }

        public void CalcularCuadrado()
        {
            int elevado;

            Console.Write("Dijite el valor a elevar: ");
            elevado = int.Parse(Console.ReadLine());

            Console.WriteLine($"El cuadrado de este numeros es: {elevado*elevado}");
            Console.ReadKey();
        }

    }
}
