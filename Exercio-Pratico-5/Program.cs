Console.WriteLine("=== Exibir informações no console ===");

Carro carro = new();

carro.ExibirInfo("Onix", "GM", "Chevrolet", 110, 2020);


Console.ReadKey();

public class Carro
{
    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano)
    {
        Console.WriteLine($"Carro do modelo: {modelo}, da seguinte montadora: {montadora}, da marca: {marca}, da seguinte potencia: {potencia}, do seguinte ano: {ano}");
    }
}