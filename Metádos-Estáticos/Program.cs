using System.Data;
using Microsoft.VisualBasic;

Console.WriteLine("=== Metádos Estáticos ===");

Calculadora calc = new();

var soma = Calculadora.Somar(10,10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.WriteLine($"O valor da soma e: {soma}");
Console.WriteLine($"O valor da subtração é: {subtrair}");
Console.WriteLine($"O valor da Multiplicação é: {multiplicar}");
Console.WriteLine($"O valor da divisão é: {dividir}");

Console.ReadKey();


public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}