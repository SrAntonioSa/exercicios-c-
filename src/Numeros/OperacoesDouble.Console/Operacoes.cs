
namespace OperacoesDouble.Console;

public class Operacoes
{
    private double a;
    private double b;

    public Operacoes(double primeiroNumero, double segundoNumero)
    {
        this.a = primeiroNumero;
        this.b = segundoNumero;
    }




    public double Soma(double a, double b) => a + b;

    public double Subtracao(double a, double b) => a - b;

    public double Multiplicacao(double a, double b) => a * b;

    public double Divisao(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return a / b;
    }

    public double Media(double a, double b) => (a + b) / 2;

}