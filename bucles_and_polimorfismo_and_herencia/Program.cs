// See https://aka.ms/new-console-template for more information

// se crea una clase abstracta

var circ = new Circulo();
circ.Radio = 30;
var resultado_area = circ.Area();
var resultado_perimetro = circ.Perimetro();

Console.WriteLine($"El area es: {resultado_area}, y el perimetro es: {resultado_perimetro}");


 abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();
}

// se crea una clase que implemente la clase abstracta creada.
class Circulo : Figura
{
    public double Radio { get; set; }
    public override double Area() => Math.PI * Radio * Radio;

    public override double Perimetro() => 2 * Math.PI * Radio;
}
