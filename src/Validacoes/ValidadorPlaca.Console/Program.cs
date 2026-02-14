using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Iniciando programa!");
        Console.WriteLine("Digite uma placa de veículo (formato ABC-1234):");
        string placa = Console.ReadLine();

        // FIX: Use the static method directly, since Placa is a static class.
        if (Placa.EhValida(placa) == false)
        {
            Console.WriteLine("A placa é inválida.");
        }
        else
        {
            Console.WriteLine("A placa é válida.");
        }
    }
}

