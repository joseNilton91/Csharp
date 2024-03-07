/* condicionales
// crear un programa que muestre si el numero es negativo o positivo.
 Console.WriteLine($"Ingrese un numero:");
 int num = int.Parse(Console.ReadLine());
 if (num > 0) Console.WriteLine("Positivo");
 else if(num < 0) Console.WriteLine("Negativo");
 else Console.WriteLine("Es cero");
 */

/* operadores*/
Console.WriteLine("Ingrese un numero:");
double numero = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero:");
double numero1 = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {numero + numero1}, Resta: {numero - numero1}, Multiplicacion: {numero * numero1}, Division: {(numero1 != 0 ? numero / numero1 : Indeterminado)}");
