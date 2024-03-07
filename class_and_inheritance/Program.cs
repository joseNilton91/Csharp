// algoritmo para crear la bases de un rectangulo.
//clase
/*Console.WriteLine("Hello, World!");
var rectan = new rectangulo();
rectan.Base = 20;
rectan.Altura = 20;
Console.WriteLine($"El area es: {rectan.Area()}");
Console.WriteLine($"El periometro es: {rectan.Perimetro()}");
*/
//end classe
var cuadra = new Cuadrado();
cuadra.Base = 20;
cuadra.Altura = 20;
Console.WriteLine($"El area es: {cuadra.Area()}");
Console.WriteLine($"El periometro es: {cuadra.Perimetro()}");
Console.WriteLine($"El lado es: {cuadra.Lado}");

class Rectangulo{
    public double Base{get; set;}
    public double Altura{get; set;}
    public double Area() => Base*Altura;
    public double Perimetro() => 2* Base + 2 * Altura;
}

//herencia
class Cuadrado : Rectangulo{
    public double Lado{
        set { Base = value; Altura = value;}
        get {return Base; }

    }

}


