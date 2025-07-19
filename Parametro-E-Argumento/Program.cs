using System.Reflection;

Console.WriteLine("=== Argumentos nomedos ===");

Email email = new();
email.Enviar("nvalentim824@gmail.com", "Urgente", "Reuniao de Orcamento");

//Argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "nvalentim824@gmail.com", assunto: "Reuniao de Orcamento");


Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \nAssunto: {assunto}");
    }
}