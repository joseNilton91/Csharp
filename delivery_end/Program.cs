// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace itm.csharp.basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}! Por favor, elija un ejercicio:");
            Menu.MostrarMenu();

            while (true)
            {
                string entrada = Console.ReadLine().ToLower();
                if (entrada == "q" || entrada == "exit")
                {
                    break;
                }
                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    switch (eleccion)
                    {

                        case 1:
                            Challenger1 challenger1 = new Challenger1();
                            challenger1.Run();
                            break;

                        case 2:
                            Challenger2 challe = new Challenger2();
                            challe.Run();
                            break;

                        case 3:
                            Challenger3 challenger3 = new Challenger3();
                            challenger3.Run();
                            break;
                        case 4:
                            Challenger4 challenger4 = new Challenger4();
                            challenger4.Run();
                            break;
                        case 5:
                            Challenger5 challenger5 = new Challenger5();
                            challenger5.Run();
                            break;
                        case 6:
                            Challenger6 challenger6 = new Challenger6();
                            challenger6.Run();

                            break;
                        case 7:
                            Challenger7 challenger7 = new Challenger7();
                            challenger7.Run();

                            break;
                        case 8:
                            Challenger8 challenger8 = new Challenger8();
                            challenger8.Run();
                            break;
                        case 9:
                            Challenger9 challenger9 = new Challenger9();
                            challenger9.Run();
                            break;
                        case 10:
                            Challenger10 challenger10 = new Challenger10();
                            challenger10.Run();
                            break;

                        case 11:
                            Challenger11 challenger11 = new Challenger11();
                            challenger11.Run();
                            break;
                        case 12:
                            Challenger12 challenger12 = new Challenger12();
                            challenger12.Run();
                            break;

                        case 13:
                            Challenger13 challenger13 = new Challenger13();
                            challenger13.Run();
                            break;

                        case 14:
                            Challenger14 challenger14 = new Challenger14();
                            challenger14.Run();
                            break;

                        case 15:
                            Challenger15 challenger15 = new Challenger15();
                            challenger15.Run();
                            break;

                        default:
                            Console.WriteLine("Presiona una tecla para continuar..");
                            Console.ReadKey();
                            Console.Clear();
                            Menu.MostrarMenu();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 15, o 'q' o 'exit' para salir");
                }
            }

            Console.WriteLine("Hasta luego");
        }
    }
}