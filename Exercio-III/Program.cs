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

//A sobrecarga de metados e util quando possuimos mais de um metado com o mesmo nome, onde podemos atribuir diferentes valores, tipos e parametros a eles
//sem que o compilador emita erro.