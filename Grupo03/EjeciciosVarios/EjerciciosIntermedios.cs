using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeciciosVarios
{
    internal class EjerciciosIntermedios
    {
        public void MenuIntermedios()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU EJERCICIOS INTERMEDIOS");
                Console.WriteLine("1. MOSTRAR NUMEROS PARES EN UN LIMITE CON INICIO Y LIMITE");
                Console.WriteLine("2. CREACION DE UN ARRAY");
                Console.WriteLine("3. MAYOR Y MENOR DENTRO DE UN ARRAY");
                Console.WriteLine("4. SALIR");

                Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Numeros pares en rango");
                        NumerosParesEnRango();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Crear el Array");
                        CreacionDeUnArray();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Numero mayor y menor en un array");
                        MayorMenorArray();
                        break;
                }


            } while (op != 4);
            //Console.ReadKey();  

        }

        public void NumerosParesEnRango()
        {
            int limite, inicio;

            Console.Write("Dijite el limite incial: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Dijite su limite final: ");
            limite = int.Parse(Console.ReadLine());

            Console.WriteLine("Estos son los pares dentro del rango limitado: ");

            for (int i = inicio;i<=limite;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        public void CreacionDeUnArray()
        {

            Console.Write("De cuantos valores quiere su Array? : ");
            int limite = int.Parse(Console.ReadLine());

            // Crear un array, en este caso va  aser de enteros pero puede ser creada de otro tipo de dato
            int[] arrayNumeros = new int[limite - 1];

            //int[] numeros = { 1, 2, 3, 4, 5 ...}; Puede ser creada directamente con los datos

            // Asignamos los valores al array
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }

            // Imprimir los elementos del array
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine(arrayNumeros[i]);
            }

            Console.ReadKey();

        }

        public void MayorMenorArray()
        {
            Console.Write("De cuantos valores quiere su Array? : ");
            int limite = int.Parse(Console.ReadLine());

            int[] mmArray = new int[limite - 1];

            for (int i = 0; i < mmArray.Length; i++)
            {
                mmArray[i] = int.Parse(Console.ReadLine());
            }

            int mayor = mmArray[0];
            int menor = mmArray[0];

            for (int i = 1; i < mmArray.Length; i++)
            {
                if (mmArray[i] > mayor)
                {
                    mayor = mmArray[i];
                }

                if (mmArray[i] < menor)
                {
                    menor = mmArray[i];
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número menor es: " + menor);

            Console.ReadKey();
        }

    }
}
