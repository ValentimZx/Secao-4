Console.WriteLine("Passando argumentos por valor\n");

int x = 20;

Console.WriteLine($"\nValor do argumento do valor x antes passar por valor {x}");

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\nValor de do argumentos depois de passar por valor x " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parametro y do metado dobrar {y}");
    }
}