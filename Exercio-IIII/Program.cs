
int x = 20;

Console.WriteLine("Valor de x antes de dobrar : " + x);

Calculo calc = new();

calc.Dobrar(ref x);

Console.WriteLine("Valor de x depois de dobrar : " + x);



public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;

        Console.WriteLine("Valor de y ja depois de ser referenciado com x e dobrado : " + y);
    }

}

// O método com referência é quando utilizamos a palavra-chave "ref" para passar um argumento.
// Primeiro, atribuímos um valor à variável "x", que está na memória.
// Depois, passamos "x" como referência para o parâmetro "y" do método Dobrar.
// Como "y" está referenciando o mesmo espaço de memória de "x", qualquer alteração feita em "y" também afeta "x".
// No código, dobramos o valor de "y", e como ele está ligado a "x", o valor de "x" também é alterado.
// É um exercício interessante para entender como funciona a passagem por referência em C#.
