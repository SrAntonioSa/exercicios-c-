
namespace BoasVindas.Console;

public class Name
{

    public string Primeiro { get; }
    public string Sobrenome { get; }

    public Name(string primeiro, string sobrenome)
    {
        Primeiro = primeiro;
        Sobrenome = sobrenome;
    }

    public string Completo() => $"{Primeiro} {Sobrenome}";
}
}
