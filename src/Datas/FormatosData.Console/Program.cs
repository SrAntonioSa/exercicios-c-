using System;
using System.Globalization;


internal class Program
{
    public static void Main()
    {
        var culture = new CultureInfo("pt-BR");
        var date = new DateTime(2024, 6, 15);


        Console.WriteLine("escolha uum formato de data:"); // construindo menu

        Console.WriteLine("1 - D - formato longo");
        Console.WriteLine("2 - d - formato curto");
        Console.WriteLine("3 - f - formato completo sem segundos");
        Console.WriteLine("4 - F - formato completo com segundos");
        Console.WriteLine("5 - g - formato geral sem segundos");
        Console.WriteLine("6 - G - formato geral com segundos");

        string opcao = Console.ReadLine();

        switch (opcao)
        {


            case "1":
                Console.WriteLine(date.ToString("D", culture)); // Sábado, 15 de junho de 2024
                break;

            case "2":
                Console.WriteLine(date.ToString("d", culture)); // 15/06/2024 
                break;

            case "3":
                Console.WriteLine(date.ToString("f", culture)); // Sábado, 15 de junho de 2024 12:00 AM
                break;

            case "4":
                Console.WriteLine(date.ToString("F", culture)); // Sábado, 15 de junho de 2024 12:00:00 AM
                break;

            case "5":
                Console.WriteLine(date.ToString("g", culture));
                break;


            case "6":
                Console.WriteLine(date.ToString("G", culture)); // 15/06/2024 12:00:00 AM
                break;
            
        }
    }

}