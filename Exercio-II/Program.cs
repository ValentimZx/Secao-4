Console.WriteLine("=== Passagem de argumento por valor ===\n");

int x = 20;

Calculo calc = new();

calc.Dobrar(x);

Console.WriteLine(x);

Console.ReadKey();


public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;

        Console.WriteLine(y);
    }
}

//Na memoria o x vai dar um valor de 20. no calc.Dobrar nos damos um valor a  ele na variavel y que esta dentro do metado dobrar
//o qual nos fazemos um calculo dem multiplicacao, e, pelo valor que damos a variavel y com a de 20 o resultado final sera 40 na variavel y.