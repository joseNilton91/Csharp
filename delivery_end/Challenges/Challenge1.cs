
namespace itm.csharp.basic
{

    // Solicita al usuario un número y eleva este número al cuadrado solo si es positivo
    public class Challenger1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                int resultado = numero * numero;
                Console.WriteLine($"El cuadrado del número {numero} es {resultado}.");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El número {numero} no se puede elevar al cuadrado, no es positivo.");
            }
            else
            {

                Console.WriteLine($"El número es cero: {numero}");
            }

        }
    }

    //Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contario devuelva el triple del segundo.
    public class Challenger2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer numero");
            int numerop = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            if (numerop > numero2)

            {
                 int resultado = (numerop * 2);
                Console.WriteLine($"El doble de {numerop} es {resultado}.");
               
            }

            else if (numerop == numero2)
            {
                 Console.WriteLine($"Los números son iguales: {numerop} y {numero2}.");
            }
            else
            {
                int resultado = numero2 * 3;
                Console.WriteLine($"El Triple de {numero2} es {resultado}.");
            }
        }
    }

    //Pida al usuario un numero. Si es positivo devuelve su raiz cuadrada,de lo contrario, devuelve su cuadrado

    public class Challenger3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero.");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num > 0)
            {
                double raizCuadrada = Math.Sqrt(num);
                Console.WriteLine($"La raiz cuadra del {num} es: {raizCuadrada}.");
            }
            else if (num < 0)
            {
                double resultado = num * num;
                Console.WriteLine($"El cuadrado del {num} numero  es: {resultado}.");
            }
            else
            {
                Console.WriteLine($"El número  es cero: {num}");
            }
        }
    }

    //Pide al usuario el radio de un círculo y calcula su perímetro
    public class Challenger4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = double.Parse(Console.ReadLine());
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"El perimetro del del circulo con radio{radio} es: {perimetro}");
        }
    }


    //Solicita al usuario un numero entre 1 y 7 y decir el dia de semana, pero solo dias laborales
    public class Challenger5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero entre 1 y 7");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes(dia laboral)");
                    break;
                case 2:
                    Console.WriteLine("Martes(dia laboral)");
                    break;
                case 3:
                    Console.WriteLine("Miercoles(dia laboral)");
                    break;
                case 4:
                    Console.WriteLine("Jueves(dia laoral)");
                    break;
                case 5:
                    Console.WriteLine("Viernes(dia laboral)");
                    break;
                case 6:
                    Console.WriteLine(" dia no laboral");
                    break;
                case 7:
                    Console.WriteLine(" dia no laboral");
                    break;
                default:
                    Console.WriteLine("Numero invalido.");
                    break;
            }
        }
    }

    //Solicita al usuario su salario anual y, si este excede los 12000,muestra el impuesto a pagar que es el 15% del excedente.
    public class Challenger6
    {
        public void Run()
        {
            Console.WriteLine(" Por favor ingrese su salario");
            double salario = double.Parse(Console.ReadLine());

            double impuesto = 0;
            if (salario > 12000)
            {
                impuesto = 0.15 * salario;
            }
            else
            {
                Console.WriteLine("No paga impuesto");
            }
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
        }
    }

    // Solicita dos números y muestra el residuo de la división del primero entre el segundo
    public class Challenger7
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese otro número: ");
            int num = int.Parse(Console.ReadLine());

            int residuo = numero % num;
            Console.WriteLine($"El residuo de {numero} / {num} es: {residuo}");
        }
    }

    //Calcula y muestra la suma de los números pares entre 1 y 50.
    public class Challenger8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0) // Comprobamos si el número es par
                {
                    suma = suma + i; //Sumamos el número par a la suma total
                }
            }
            Console.WriteLine($"La suma de los numeros pares entre 1 y 50 es: {suma}");
        }
    }

    //Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones.
    public class Challenger9
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingrese numerador de la primera fracción:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese denominador de la primera fracción:");
                int den1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese numerador de la segunda fracción:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese denominador de la segunda fracción:");
                int den2 = int.Parse(Console.ReadLine());

                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Resta(fraccion2);

                Console.WriteLine($"La resta de {fraccion1} y {fraccion2} es: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero");
            }
            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Resta(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

    //Pide una palabra al usuario y muestra la longitud de esa palabra.
    public class Challenger10
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            int longitud = palabra.Length;
            Console.WriteLine($"La longitud de la palabra {palabra} es: {longitud}");
        }
    }

    //Pide al usuario cuatro números y muestra el promedio.
    public class Challenger11
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el numero1");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            int numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            int numero4 = int.Parse(Console.ReadLine());
            int promedio = ((numero1 + numero2 + numero3 + numero4) / 4);
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
    // Pide al usuario cinco números y muestra el más pequeño.
    public class Challenger12
    {
        public void Run()
        {
            try
            {
                // Solicita al usuario cinco números
                double[] numeros = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Ingrese el número {i + 1}: ");
                    numeros[i] = double.Parse(Console.ReadLine());
                }

                // Encuentra el número más pequeño
                double numeroMasPequeno = numeros[0];
                for (int i = 1; i < 5; i++)
                {
                    if (numeros[i] < numeroMasPequeno)
                    {
                        numeroMasPequeno = numeros[i];
                    }
                }

                Console.WriteLine($"El número más pequeño es: {numeroMasPequeno}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    //Pide una palabra al usuario y devuelve el número de vocales en esa palabra
    public class Challenger13
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingrese una palabra:");
                string palabra = Console.ReadLine();

                // Calcula el número de vocales en la palabra
                int numVocales = ContarVocales(palabra);

                Console.WriteLine($"La palabra '{palabra}' tiene {numVocales} vocales.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public static int ContarVocales(string palabra)
        {
            // Definir las vocales
            string vocales = "aeiouAEIOU";

            // Inicializar el contador de vocales
            int contador = 0;

            // Contar las vocales en la palabra
            foreach (char letra in palabra)
            {
                if (vocales.Contains(letra))
                {
                    contador++;
                }
            }

            return contador;
        }
    }

    //  Pide un número al usuario y devuelve el factorial de ese número.
    public class Challenger14
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());

            long factorial = CalcularFactorial(numero); // Calcular el factorial del número ingresado

            Console.WriteLine($"El factorial de {numero} es: {factorial}");  // Mostrar el factorial
        }

        static long CalcularFactorial(int n) // Función para calcular el factorial de un número
        {
            if (n < 0)
            {
                throw new ArgumentException("El factorial no está definido para números negativos.");
            }
            else if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                long resultado = 1;
                for (int i = 2; i <= n; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }
        }
    }

    // Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos).
    public class Challenger15
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no está en el rango de 10 a 20.");
            }
        }
    }
}

