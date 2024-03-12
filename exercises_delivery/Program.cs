using System;

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

                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 21)
                {
                    switch (eleccion)
                    {
                        case 1:
                            Challenger1 ejer1 = new Challenger1();
                            ejer1.Run();
                            break;

                        case 2:
                            Challenger2 ejer2 = new Challenger2();
                            ejer2.Run();
                            break;

                        case 3:
                            Challenger3 ejer3 = new Challenger3();
                            ejer3.Run();
                            break;

                        case 4:
                            Challenger4 ejer4 = new Challenger4();
                            ejer4.Run();
                            break;

                        case 5:
                            Challenger5 ejer5 = new Challenger5();
                            ejer5.Run();
                            break;

                        case 6:
                            Challenger6 ejer6 = new Challenger6();
                            ejer6.Run();
                            break;

                        case 7:
                            Challenger7 ejer7 = new Challenger7();
                            ejer7.Run();
                            break;

                        case 8:
                            Challenger8 ejer8 = new Challenger8();
                            ejer8.Run();
                            break;

                        case 9:
                            Challenger9 ejer9 = new Challenger9();
                            ejer9.Run();
                            break;

                        case 10:
                            Challenger10 ejer10 = new Challenger10();
                            ejer10.Run();
                            break;

                        case 11:
                            Challenger11 ejer11 = new Challenger11();
                            ejer11.Run();
                            break;

                        case 12:
                            Challenger12 ejer12 = new Challenger12();
                            ejer12.Run();
                            break;

                        case 13:
                            Challenger13 ejer13 = new Challenger13();
                            ejer13.Run();
                            break;

                        case 14:
                            Challenger14 ejer14 = new Challenger14();
                            ejer14.Run();
                            break;

                        case 15:
                            Challenger15 ejer15 = new Challenger15();
                            ejer15.Run();
                            break;

                        case 16:
                            Challenger16 ejer16 = new Challenger16();
                            ejer16.Run();
                            break;

                        case 17:
                            Challenger17 ejer17 = new Challenger17();
                            ejer17.Run();
                            break;

                        case 18:
                            Challenger18 ejer18 = new Challenger18();
                            ejer18.Run();
                            break;

                        case 19:
                            Challenger19 ejer19 = new Challenger19();
                            ejer19.Run();
                            break;

                        case 20:
                            Challenger20 ejer20 = new Challenger20();
                            ejer20.Run();
                            break;

                        case 21:
                            Challenger21 ejercicio21 = new Challenger21();
                            ejercicio21.Run();
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
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 21, o 'q' o 'exit' para salir");
                }
            }

            Console.WriteLine("Hasta luego");
        }
    }
}
