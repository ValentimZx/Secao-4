using System.Configuration.Assemblies;

Console.WriteLine("=== Passagem de refrencia - out ===\n");

Console.WriteLine("Informe o raio do circulo:  ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalculaPerimetro(raio);
double area = circulo.CalculaArea(raio);

Console.WriteLine("Perimetro da circunferencia: " + perimetro);
Console.WriteLine("Area da circunferencia: " + area);


Console.ReadKey();



public class Circulo
{
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }
    public double CalculaPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}


//Metado sem out