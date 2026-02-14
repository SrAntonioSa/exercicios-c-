


using OperacoesDouble.Console;
using System.Globalization;


internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número decimal separado por ponto: ");
        double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double primeiroNumero);

        Console.Write("Digite o segundo número decimal separado por ponto: ");
        double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double segundoNumero);

        var Numeros = new Operacoes(primeiroNumero, segundoNumero);

        Console.WriteLine($"A soma dos números é: {Numeros.Soma(primeiroNumero, segundoNumero)}");
        Console.WriteLine($"A subtração dos números é: {Numeros.Subtracao(primeiroNumero, segundoNumero)}");
        Console.WriteLine($"A multiplicação dos números é: {Numeros.Multiplicacao(primeiroNumero, segundoNumero)}");
        Console.WriteLine($"A divisão dos números é: {Numeros.Divisao(primeiroNumero, segundoNumero)}");
        Console.WriteLine($"A média dos números é: {Numeros.Media(primeiroNumero, segundoNumero)}");
    }
}