using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeciciosVarios
{
    internal class EjerciciosAvanzados
    {
        public void MenuAvanzados()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU EJERCICIOS AVANZADOS");
                Console.WriteLine("1. ¿TU FRASE ES PALINDROMA?");
                Console.WriteLine("2. METODO DE ORDENAMIENTO BURBUJA");
                Console.WriteLine("3. CREACION DE UNA MATRIZ");
                Console.WriteLine("4. SALIR");

                Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Saber si tu frase es palindroma");
                        FrasePalindroma();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ordenar el Array metodo burbuja");
                        OrdenamientoBurbuja();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Crear una Matriz");
                        CreacionDeUnaMatriz();
                        break;
                }


            } while (op != 4);
            //Console.ReadKey();  

        }
        
        public void FrasePalindroma()
        {
            Console.Write("Ingrese una frase: ");
            string fraseConEspacios = Console.ReadLine();

            //La frase inicial la convierte completamente en minuscula para no obtener ningun error
            string fraseMinuscula = fraseConEspacios.ToLower();

            //Luego de eso elimina los espacios de las frase, o mejor dicho, remplaza los espacios con un caracter vacio
            string fraseSinEspacios = fraseMinuscula.Replace(" ","");


            string reverseFrase = new string(fraseSinEspacios.Reverse().ToArray());

            if (fraseSinEspacios == reverseFrase)
            {
                Console.WriteLine("La frase es un palíndroma.");
            }
            else
            {
                Console.WriteLine("La frase no es un palíndroma.");
            }

            Console.ReadKey();

        }

        public void OrdenamientoBurbuja()
        {
            int[] arrayBurbuja = new int[10];

            Console.WriteLine("Ingrese valores al array en cualquier orden: ");
            for (int i = 0; i < arrayBurbuja.Length; i++)
            {
                arrayBurbuja[i] = int.Parse(Console.ReadLine());
            }

            //Metodo de ordenamiento burbuja
            for (int i = 0; i < arrayBurbuja.Length; i++)
            {
                for (int j = 0; j < arrayBurbuja.Length - 1; j++)
                {
                    if (arrayBurbuja[j] > arrayBurbuja[j + 1])
                    {
                        int vaso = arrayBurbuja[j];
                        arrayBurbuja[j] = arrayBurbuja[j + 1];
                        arrayBurbuja[j + 1] = vaso;
                    }
                }
            }

            foreach (int valor in arrayBurbuja)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();

        }

        public void CreacionDeUnaMatriz()
        {

            Console.Write("Cuantas filas ( [?,] ) desea tener en su matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Cuantas columnas ( [,?] ) desea tener en su matriz: ");
            int columnas = int.Parse(Console.ReadLine());


            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese un número para la posición [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz ingresada fue:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
