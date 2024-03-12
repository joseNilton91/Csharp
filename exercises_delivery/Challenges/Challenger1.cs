using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace itm.csharp.basic
{
    //Se le solicita al usuario ingresar un numero y decir si es negativo o positivo o es cero..
    public class Challenger1
    {

        public void Run()
        {
            Console.WriteLine("Por favor digite un número:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Positivo");
            else if (num < 0)
                Console.WriteLine("Negativo");
            else
                Console.WriteLine("Es cero");
        }
    }

    public class Challenger2
    {
        // Ingresa dos numeros y decir cual de los dos es mayor
        public void Run()
        {
            Console.WriteLine("Ingrese un numero;");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero;");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(" El numero 1 es mayor:");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El numero2 es mayor:");
            }
            else
            {
                Console.WriteLine(" Los numeros son iguales");
            }
        }
    }

    public class Challenger3
    // Operaciones basicas entre dos numeros.
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero:");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero:");
            double numero1 = double.Parse(Console.ReadLine());
            const string Indeterminado = "Indeterminado";
            Console.WriteLine($"Suma: {numero + numero1}, Resta: {numero - numero1}, Multiplicacion: {numero * numero1}, Division: {(numero1 != 0 ? numero / numero1 : Indeterminado)}");

        }
    }

    public class Challenger4
    {
        //Solicitar al usuario un numero y dar el cuadrado de ese numero.
        public void Run()
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"El cuadrado de {numero} es: {numero * numero}");

        }
    }

    public class Challenger5
    {
        //Solicitar al usuario el radio de un circulo y mostrar el area.
        public void Run()
        {
            Console.WriteLine("Ingrese el radio");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.PI * radio * radio;
            Console.WriteLine($"El area del del circulo con radio {radio} es: {area}");

        }
    }

    public class Challenger6
    {
        //Solicita al usuario un numero entre 1 y 7 y decir el dia de semana.
        public void Run()
        {
            Console.WriteLine("Ingrese un numero entre 1 y 7");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("El dia es lunes");
                    break;
                case 2:
                    Console.WriteLine("El dia es martes");
                    break;
                case 3:
                    Console.WriteLine("El dia es miercoles");
                    break;
                case 4:
                    Console.WriteLine("El dia es jueves");
                    break;
                case 5:
                    Console.WriteLine("El dia es viernes");
                    break;
                case 6:
                    Console.WriteLine("El dia es sabadno");
                    break;
                case 7:
                    Console.WriteLine("El dia es domingo");
                    break;
                default:
                    Console.WriteLine("Numero invalido.");
                    break;
            }
        }
    }
    public class Challenger7
    {
        //Solicita al usurio su salario mensual, si excede de 1000, mostrar el impuesto a pagar(10% del salario
        public void Run()
        {
            Console.WriteLine("Ingrese el valor de su salario");
            double salario = double.Parse(Console.ReadLine());

            double impuesto = 0;
            if (salario > 1000)
            {
                impuesto = 0.1 * salario;
            }
            else
            {
                Console.WriteLine("No paga impuesto");
            }
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
        }
    }
    public class Challenger8
    {
        //Solicita al usurio dos numeros y realiza una division.
        public void Run()
        {
            try
            {
                Console.WriteLine("Numero a Dividir:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero divisor:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {numero / num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" El numero no se puede dividir por cero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Erroe al realizat la operacion.");
            }
        }
    }

    public class Challenger9
    {
        //Mostrar la suma de los numeros impares entre 1 y 100.
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los numeros impares entre 1 y 100 es: {suma}");
        }
    }

    public class Challenger10
    {
        //Solicita al usuario los valores para dos fracciones y mostrar la suma de esas fracciones.
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

                Fraccion resultado = fraccion1.Sumar(fraccion2);

                Console.WriteLine($"La suma de {fraccion1} y {fraccion2} es: {resultado}");
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

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador + otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

    //Solicita al usuario una palabra y se muestra en el orden inverso.
    public class Challenger11
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            string invertida = new string(palabra.Reverse().ToArray());
            Console.WriteLine($"La palabra invertida es: {invertida}");
        }
    }
    //Solicita al usuario tres numeros y muestra el promedio de esos numeros.
    public class Challenger12
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer numero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            double num3 = double.Parse(Console.ReadLine());
            double promedio = ((num1 + num2 + num3) / 3);
            Console.WriteLine($"El promedio  es: {promedio}");
        }
    }


    //Solicita al usuario 5 numeros y se muestra el mas grande entre ellos.
    public class Challenger13
    {
        public void Run()
        {

            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce el numero {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"El numero mas grande de la lista es: {numeros.Max()}");
        }
    }

    // Solicita al usuario una palabra y determine si es un polindromo(se lee igual de izquierda a derecha, que de dercha a izquierda).
    public class Challenger14
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            if (palabra == new string(palabra.Reverse().ToArray()))
            {
                Console.WriteLine($" La palabra {palabra} es un polindromo.");
            }
            else
            {
                Console.WriteLine($" La palabra {palabra} no es un polindromo.");
            }
        }
    }

    //Solicita al usuario un numero y mostrar si es par o impar
    public class Challenger15
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($" El numero {numero} es par.");
            }
            else
            {
                Console.WriteLine($" El numero {numero} es impar.");
            }
        }
    }

    //Operaciones bancarias
    public class Challenger16
    {
        static double saldo = 0.0; // Saldo inicial

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nOpciones disponibles:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Consignar dinero");
                Console.WriteLine("3. Realizar retiro");
                Console.WriteLine("4. Salir");

                Console.Write("Seleccione una opción (1-4): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Su saldo actual es: ${saldo}");
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad a depositar: $");
                        double deposito = double.Parse(Console.ReadLine());
                        saldo = (saldo + deposito);
                        Console.WriteLine($"Depósito exitoso. Su nuevo saldo es: ${saldo}");
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad a retirar: $");
                        double retiro = double.Parse(Console.ReadLine());
                        if (retiro <= saldo)
                        {
                            saldo = (saldo - retiro);
                            Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: ${saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Fondos insuficientes. No se puede realizar el retiro.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("¡Gracias por usar nuestros servicios!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }

    //Determinar si un año es bisiesto.
    public class Challenger17
    {
        public void Run()
        {
            Console.WriteLine("Porfavor ingrese un año:");
            int año = int.Parse(Console.ReadLine());

            if (año > 0)
            {

                if (Esbisiesto(año))
                {
                    Console.WriteLine($" {año},Es un bisiesto");
                }
                else
                {
                    Console.WriteLine($"{año}, No es un bisiesto");
                }

            }
            else
            {
                Console.WriteLine("Por favor ingrese un año positivo.");
            }
        }

        private bool Esbisiesto(int año)
        {
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }


    //Categorizar por edad.
    public class Challenger18
    {
        public void Run()
        {

            Console.Write("Ingrese su edad: ");
            string edadimput = Console.ReadLine();

            if (int.TryParse(edadimput, out int edad))
            {
                string categoria = ObtenerCategoria(edad);
                Console.WriteLine($"Usted pertenece a la categoría: {categoria}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese una edad válida.");
            }

            Console.ReadLine();
        }

        static string ObtenerCategoria(int edad)
        {
            if (edad >= 0 && edad <= 5)
            {
                return "Infante";
            }
            else if (edad >= 6 && edad <= 12)
            {
                return "Niño";
            }
            else if (edad >= 13 && edad <= 17)
            {
                return "Adolescente";
            }
            else if (edad >= 18 && edad <= 64)
            {
                return "Adulto";
            }
            else
            {
                return "Adulto Mayor";
            }
        }
    }

    //Agregar contactos a una agenda.
    public class Challenger19
    {
        public void Run()
        {
            List<Contacto> agenda = new List<Contacto>();

            while (true)
            {
                Console.Write("Ingresa el nombre del contacto (o deja vacío para salir): ");
                string nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                    break;

                Console.Write("Ingresa el número de teléfono: ");
                string telefono = Console.ReadLine();

                Contacto nuevoContacto = new Contacto(nombre, telefono);
                agenda.Add(nuevoContacto);

                Console.WriteLine($"Contacto '{nombre}' agregado correctamente.");
            }

            Console.WriteLine("\nAgenda de contactos:");
            foreach (var contacto in agenda)
            {
                Console.WriteLine($"{contacto.Nombre}: {contacto.Telefono}");
            }
        }
    }

    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
    }

    //Animales hablando
    public class Challenger20
    {
        public void Run()
        {
            List<Animal> animales = new List<Animal>();

            // Crear instancias de diferentes tipos de animales
            animales.Add(new Perro("Buddy"));
            animales.Add(new Gato("Whiskers"));
            animales.Add(new Pajaro("Tweetie"));

            // Hacer que los animales hablen
            foreach (var animal in animales)
            {
                Console.WriteLine($"{animal.Nombre} dice: {animal.Hablar()}");
            }

            Console.ReadLine();
        }
    }

    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string Hablar()
        {
            return "Hace algún sonido indefinido";
        }
    }

    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public override string Hablar()
        {
            return "Guau guau";
        }
    }

    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        public override string Hablar()
        {
            return "Miau";
        }
    }

    public class Pajaro : Animal
    {
        public Pajaro(string nombre) : base(nombre) { }

        public override string Hablar()
        {
            return "Pío pío";
        }
    }

    //Comportamiento de vehiculos.
    public class Challenger21
    {
        public void Run()
        {
            Console.WriteLine("Ingrese la información del vehículo:");

            Console.Write("Tipo (Auto, Moto, Camión, etc.): ");
            string tipo = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            // Crear una instancia de Vehiculo
            var miVehiculo = new Vehiculo
            {
                Tipo = tipo,
                Marca = marca,
                Modelo = modelo
            };

            Console.WriteLine("\nInformación del vehículo registrado:");
            miVehiculo.MostrarInformacion();

            Console.WriteLine("\nGracias por registrar el vehículo.");
        }
    }

    class Vehiculo
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }

}