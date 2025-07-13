Console.WriteLine("Passando argumentos por referencia\n");

int x = 20;

Console.WriteLine($"\nValor do argumento do valor x antes passar por valor {x}");

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumentos depois de passar por valor x " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parametro y do metado dobrar {y}");
    }
}