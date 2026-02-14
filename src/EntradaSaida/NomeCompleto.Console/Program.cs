

internal class Program
{
    static void Main()


    {
        Console.WriteLine("Iniciando programa!");
        Console.WriteLine("indique seu nome:");
        Console.Write("Primeiro nome: ");
        string primeiroNome = Console.ReadLine();
        Console.Write("Segundo nome: ");
        string segundoNome = Console.ReadLine();
        var name = new Name(primeiroNome, segundoNome);
        Console.WriteLine($"Olá, {name.Completo()}!");
    }
}
