

        IPVA.ObterValorIPVA(); // Atribui o valor 4% ao campo estático

        IPVA ipva = new IPVA();
        ipva.Carro = "Onix";

        Console.WriteLine($"Valor do IPVA do {ipva.Carro} é {IPVA.ValorIPVA}%");
   


public class IPVA
{
    public string? Carro;
    public static double ValorIPVA;

    public static void ObterValorIPVA()
    {
        ValorIPVA = 4;
    }
}
