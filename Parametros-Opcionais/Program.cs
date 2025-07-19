Console.WriteLine("=== Parametros Opcionais ===");

Console.WriteLine("Infome o destino: ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o Titulo: ");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o Assunto: ");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

//não posso fazer
//email.Enviar(destino, , assunto) causa erro


Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino padrao", string titulo = "Titulo padrao", string assunto = "Assunto Padrao")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \nAssunto: {assunto}");
    }
}