using System.Text.RegularExpressions;

public static class Placa
{

// cria um padrao da placa
    private static readonly Regex RegexPlaca =
        new Regex(@"^[A-Z]{3}-?\d{4}$", RegexOptions.Compiled);



    // verifica se o padrao e respeitado pela placa fornecida pelo usuario
    public static bool EhValida(string placa)
    {
        if (string.IsNullOrWhiteSpace(placa))
            return false;

        placa = placa.Trim().ToUpper();

        return RegexPlaca.IsMatch(placa);
    }
}
