internal class Program
{
    private static void Main(string[] args)
    {
        

            Console.WriteLine("Iniciando programa!");
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();
            int contador = 0;
            foreach (char c in frase)
            {
                if (char.IsLetter(c))
                {
                    contador++;
                }
            }
            Console.WriteLine($"A frase digitada tem {contador} caracteres alfabéticos.");
        
    }
}