using System;

public class Aluno
{
    public int RA { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; set; }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2.0;
    }

    public bool CalcularNotaFinal(double notaMinimaAprovacao)
    {
        double media = NotaFinal;
        double notaNecessaria = Math.Round((notaMinimaAprovacao * 2.0 - media), 2);

        Console.WriteLine($"Nota necessária na prova final: {notaNecessaria}");

        if (notaNecessaria <= 10 && notaNecessaria >= 0)
        {
            double notaFinal = (media + notaNecessaria) / 2.0;
            NotaFinal = notaFinal;
            Console.WriteLine($"Nota final: {notaFinal}");

            if (notaFinal >= notaMinimaAprovacao)
            {
                Console.WriteLine("Aprovado!");
                return true;
            }
            else
            {
                Console.WriteLine("Reprovado!");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Não é possível alcançar essa nota na prova final.");
            Console.WriteLine("Reprovado!");
            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota final do aluno {Nome} (RA: {RA}): {NotaFinal}");
    }

    public void ReceberDados()
    {
        Console.Write("Digite o RA do aluno: ");
        RA = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do aluno: ");
        Nome = Console.ReadLine();

        Console.Write("Digite a nota da prova do aluno: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota do trabalho do aluno: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }
}
