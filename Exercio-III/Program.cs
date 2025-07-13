using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("=== Metado sobrecarga ===\n");

Potencia p = new();
p.AumentarPotencia();

p.AumentarPotencia(10);




public class Potencia
{
    public void AumentarPotencia()
    {
        Console.WriteLine("Aumentando potencia padrao...");
    }

    public void AumentarPotencia(int novaPotencia)
    {

        novaPotencia += 5;
        Console.WriteLine("O Aumento da potencia foi de " + novaPotencia);

    }
}