
using Microsoft.VisualBasic;


Console.WriteLine("Informe o modelo do carro: ");
var modelo = Console.ReadLine();

Console.WriteLine("Informe a marca do carro: ");
var marca = Console.ReadLine();

Console.WriteLine("Informe a motadora do carro: ");
var montadora = Console.ReadLine();

Console.WriteLine("Informe a potencia do carrro: ");
var potencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o ano: ");
var ano = Convert.ToInt32(Console.ReadLine());

Carro carro = new();
carro.ExibirInfo();
carro.ExibirInfo(modelo);
carro.ExibirInfo(modelo, marca);
carro.ExibirInfo(modelo, marca, montadora);
carro.ExibirInfo(modelo, marca, montadora, potencia);
carro.ExibirInfo(modelo, marca, montadora, potencia, ano);

Console.WriteLine($"Carro do modelo: {modelo}, da marca: {marca}, da montadora: {montadora}, da potencia {potencia} ano: {ano}");




public class Carro
{
    public void ExibirInfo(string modelo = "Modelo Padrao", string marca = "Marca Padrão", string montadora = "Montadora Padrà", int potencia = 110, int ano = 2020)
    {
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Ano: {ano}");

    }
}