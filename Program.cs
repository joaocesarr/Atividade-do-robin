using System;

public class Calculadora
{
    private double ValorA { get; set; }
    private double ValorB { get; set; }
    private double Resultado { get; set; }
    private Calculo calculo = new Calculo();

    public void LerValores()
    {
        Console.Write("Digite o valor de A: ");
        ValorA = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        ValorB = double.Parse(Console.ReadLine());
    }

    public void CalcularSoma()
    {
        Resultado = calculo.Somar(ValorA, ValorB);
    }

    public void CalcularSubtracao()
    {
        Resultado = calculo.Subtrair(ValorA, ValorB);
    }

    public void CalcularMultiplicacao()
    {
        Resultado = calculo.Multiplicar(ValorA, ValorB);
    }

    public double RetornarMaior()
    {
        return calculo.RetornarMaior(ValorA, ValorB);
    }

    public void SomarGeral(double valor)
    {
        Resultado = calculo.SomarGeral(ValorA, ValorB, valor);
    }

    public void ImprimirResultado()
    {
        Console.WriteLine("Resultado: " + Resultado);
    }

    public void ExecutarCalculadora()
    {
        Console.WriteLine("Selecione a operação desejada:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Retornar o maior valor");
        Console.WriteLine("5 - Somar com um valor adicional");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        LerValores();

        switch (opcao)
        {
            case 1:
                CalcularSoma();
                break;
            case 2:
                CalcularSubtracao();
                break;
            case 3:
                CalcularMultiplicacao();
                break;
            case 4:
                Resultado = RetornarMaior();
                break;
            case 5:
                Console.Write("Digite o valor adicional: ");
                double valorAdicional = double.Parse(Console.ReadLine());
                SomarGeral(valorAdicional);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        ImprimirResultado();
    }
}

public class Calculo
{
    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double RetornarMaior(double a, double b)
    {
        return a > b ? a : b;
    }

    public double SomarGeral(double a, double b, double valorAdicional)
    {
        return a + b + valorAdicional;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        calculadora.ExecutarCalculadora();
    }
}
