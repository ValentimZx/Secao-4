using System;

class Program
{
    static void Main()
    {
        int potencia = 10;
        Aumentar aumentar = new Aumentar();

        double velocidade;
        int novaPotencia = aumentar.AumentarPotenciaVelocidade(potencia, out velocidade);

        Console.WriteLine($"Nova potência: {novaPotencia}");
        Console.WriteLine($"Nova velocidade: {velocidade}");

        Console.ReadKey();
    }
}

public class Aumentar
{
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;                    // Incrementa a potência em 7
        velocidade = potencia * 1.75;    // Calcula a velocidade como potência * 1.75
        return potencia;                 // Retorna a nova potência
    }
}
