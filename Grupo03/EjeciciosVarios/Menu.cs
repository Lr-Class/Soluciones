using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeciciosVarios
{
    public class Menu
    {
        public void MenuPrincipal() 
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20,7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18,9); Console.Write("1. EJERCICIOS BASICOS");
                Console.SetCursorPosition(18, 11); Console.Write("2. EJERCICIOS INTERMEDIOS");
                Console.SetCursorPosition(18, 13); Console.Write("3. EJERCICIOS AVANZADOS");

                Console.SetCursorPosition(18, 15); Console.Write("4. salir");

                Console.SetCursorPosition(27, 15); Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        new EjerciciosBasicos().MenuBasicos();
                        break;
                    case 2:
                        Console.Clear();
                        new EjerciciosIntermedios().MenuIntermedios();
                        break;
                    case 3:
                        Console.Clear();
                        new EjerciciosAvanzados().MenuAvanzados();
                        break;
                }


            } while (op != 4);
        }

    }
}
