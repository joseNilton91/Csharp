using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
             DateOnly  DateConverted = new  DateOnly();
            string nameimput;
            string birthdayimput;
            Console.WriteLine("!Hola bienvenido al calculador de año!:");
            Console.WriteLine($"Por favor escribe tu nombre:");
            nameimput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameimput}:");
            Console.WriteLine($"Escribe tu fecha de nacimiento en formato dd/mm/aa/:");
            birthdayimput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayimput, out DateConverted);
            if (isDateValid == false) Console.WriteLine($"La fecha ingresada no es valida {birthdayimput}");
             
             var person = new Person{
                Name1 = nameimput,
                Birthday = DateConverted,
                Age = DateTime.Now.Year - DateConverted.Year
             };
             Console.WriteLine($"Tu nombre: {person.Name1}");
             Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
             Console.WriteLine($"!Tu edad es {person.Age} años:!");
            Console.ReadLine();
        }
    }
    //creacion de la primera clase
    public class Person
    {
        public string Name1 { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }

    }
}