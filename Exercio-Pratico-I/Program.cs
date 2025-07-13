Carro car = new();

int novaPotencia = car.AumentarPotencia();
Console.WriteLine("O Aumento da nova potencia foi de : " + novaPotencia);
public class Carro
{
    public int AumentarPotencia(int potencia = 10)
    {
        potencia += 3;
        return potencia;
    }
}